using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppCordTask.Data.Entities
{
    public class MessageLog
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        [ForeignKey("PhoneNumber")]
        public int PhoneNumberId { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
    }
}
