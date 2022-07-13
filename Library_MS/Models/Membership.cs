using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_MS.Models
{
    public class Membership
    {
        public int id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}