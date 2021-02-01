using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppCordTask.Data.Entities
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public virtual List<MessageLog> MessageLogs { get; set; }
    }
}
