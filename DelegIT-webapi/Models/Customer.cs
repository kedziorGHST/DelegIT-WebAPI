using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        public string fullCompanyName { get; set; }
        public string shortCompanyName { get; set; }
        public string nip { get; set; }
        public string managerFName { get; set; }
        public string managerLName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string postCode { get; set; }
    }
}
