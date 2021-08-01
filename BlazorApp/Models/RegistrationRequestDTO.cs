using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RegistrationRequestDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9]+.[a-zA-Z0-9-.]+$")]
        public string Email { get; set; }
        [Required]
        [RegularExpression("^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-./0-9]*$")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
