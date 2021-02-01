using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCordTask.Models
{
    public class AddPhoneNumberMessageInputViewModel
    {
        [Required]
        public string Message { get; set; }
    }
}
