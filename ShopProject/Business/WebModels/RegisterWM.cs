using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.WebModels
{
    public class RegisterWM
    {
        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Passwd { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Passwd")]
        public string RePasswd { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
