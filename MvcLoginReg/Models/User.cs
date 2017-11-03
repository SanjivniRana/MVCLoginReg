using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLoginReg.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Userid { get; set; }
        public string Password { get; set; }
        public string ConformPassword { get; set; }
    }
}