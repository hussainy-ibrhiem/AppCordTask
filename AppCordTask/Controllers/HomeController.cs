using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppCordTask.Models;
using Microsoft.AspNetCore.Authorization;
using AppCordTask.Data;
using Microsoft.EntityFrameworkCore;
using AppCordTask.Data.Entities;

namespace AppCordTask.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> SendMessageToPhone(AddPhoneNumberMessageInputViewModel addPhoneNumberMessageInputViewModel)
        {
            TempData["Referrer"] = "Done";
            List<PhoneNumber> randomNumbers = await _dbContext.PhoneNumbers.Where(x => !x.MessageLogs.Select(x => x.PhoneNumberId).Contains(x.Id)).Take(10).ToListAsync();
            randomNumbers.ForEach(async phoneNumber =>
                    {
                        await _dbContext.MessageLogs.AddAsync(new MessageLog
                        {
                            Message = addPhoneNumberMessageInputViewModel.Message,
                            PhoneNumberId = phoneNumber.Id
                        });
                    });
            bool added = await _dbContext.SaveChangesAsync() > default(int);
            TempData["Referrer"] = added ? "SaveRegister" : "";
            return View("Index");
        }
    }
}
