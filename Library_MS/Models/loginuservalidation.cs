using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library_MS.Models
{
    [MetadataType(typeof(loginuserMetaData))]
    public partial class loginuser
    {
        public class loginuserMetaData
        {
            [DisplayName("User Name")]
            [Required(ErrorMessage = "This Field is Required")]

            public string UserName { get; set; }

            [DisplayName("Password")]
            [Required(ErrorMessage = "This Field is Required")]
            [DataType(DataType.Password)]

            public string Password { get; set; }

        }
    }
}