using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class Amenity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0,24, ErrorMessage ="Please enter the time between 0 and 24")]
        public float StartTime { get; set; }
        [Required]
        [Range(0, 24, ErrorMessage = "Please enter the time between 0 and 24")]
        public float EndTime { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}
