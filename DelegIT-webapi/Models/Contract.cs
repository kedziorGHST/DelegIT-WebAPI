using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Contract
    {
        [Key]
        public int id { get; set; }
        public string type { get; set; }
        public int customerId { get; set; }
        [ForeignKey("customerId")]
        public Customer customer { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public string range { get; set; }

    }
}
