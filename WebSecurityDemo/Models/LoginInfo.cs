using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebSecurityDemo.Models {
    public class LoginInfo {
        [Required]
        public string UN { get; set; }
        [Required]
        public string PW { get; set; }
    }
}