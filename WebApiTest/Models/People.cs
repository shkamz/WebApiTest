using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTest.Models
{
    public class People
    {
        public int Id { get; set; } = 0;
        public string[] FirstName { get; set; } 

        public string LastName { get; set; } = "";

        public string MiddleName { get; set; } = ""; 

        public string DateTime { get; set; }
    }
}