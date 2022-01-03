using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
  public class FileTransfer
    {
        [Key]
        public int Id { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Password { get; set; }
    }
}
