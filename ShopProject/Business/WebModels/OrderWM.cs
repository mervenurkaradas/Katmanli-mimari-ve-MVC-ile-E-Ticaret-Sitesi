using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.WebModels
{
   public class OrderWM
    {
        public CartWM CartWM { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Display(Name ="Şehir")]
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
