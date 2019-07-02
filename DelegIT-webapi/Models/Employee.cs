using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string companyName { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string streetNumber { get; set; }
        public string position { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string postCode { get; set; }
    }
}
