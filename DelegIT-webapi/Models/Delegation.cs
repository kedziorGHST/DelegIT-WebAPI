using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Delegation
    {
        [Key]
        public int id { get; set; }
        public int contractId { get; set; }
        [ForeignKey("contractId")]
        public Contract contract { get; set; }
        [Required]
        public DateTime orderDate { get; set; }
        [Required]
        public DateTime departureDate { get; set; }
        [Required]
        public DateTime arrivalDate { get; set; }
        [Required]
        public int numberDelegation { get; set; }
        [Required]
        public string purpose { get; set; }
        [Required]
        public string transport { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string type { get; set; }
        public int lumpSum { get; set; }
        public int driveCost { get; set; }
        public int driveSum { get; set; }
        public int diet { get; set; }
        public int accomodationCost { get; set; }
        public int otherCost { get; set; }

    }
}
