//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_MS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class user
    {
        public int id { get; set; }

        [Required(ErrorMessage="This field is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage= "This field is required")]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
    }
}