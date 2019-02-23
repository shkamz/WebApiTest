using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebApiTest.Models
{
    public class People
    {
        [Required]
        [JsonProperty("id")]
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } 

        public string LastName { get; set; } = "";

        public string MiddleName { get; set; } = ""; 

        public string DateTime { get; set; }
        
        public string Lol {get; set; }
        public string NoName { get; set; }
    }
}
