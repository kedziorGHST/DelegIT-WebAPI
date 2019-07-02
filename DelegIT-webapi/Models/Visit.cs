using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Visit
    {
        [Key]
        public int id { get; set; }
        public int employeeId { get; set; }
        [ForeignKey("employeeId")]
        public Employee employee { get; set; }
        public int contractId { get; set; }
        [ForeignKey("contractId")]
        public Contract contract { get; set; }
        public int workingHours { get; set; }
        public string type { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }
}
