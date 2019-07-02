using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DelegIT_webapi.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string model { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string company { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string type { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string plates { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string colour { get; set; }
        [Required]
        public int horsePower { get; set; }
    }
}
