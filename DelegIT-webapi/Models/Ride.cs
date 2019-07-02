using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Ride
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int employeeId { get; set; }
        [ForeignKey("employeeId")]
        public Employee employee { get; set; }
        [Required]
        public int carId { get; set; }
        [ForeignKey("carId")]
        public Car car { get; set; }
        [Required]
        [Column(TypeName = "varchar(40)")]
        public string whence { get; set; }
        [Required]
        [Column(TypeName = "varchar(40)")]
        public string where { get; set; }
        [Required]
        public DateTime from { get; set; }
        [Required]
        public DateTime until { get; set; }
    }
}
