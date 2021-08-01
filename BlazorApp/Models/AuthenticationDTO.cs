using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AuthenticationDTO
    {
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9]+.[a-zA-Z0-9-.]+$")]
        public string UserName { get; set; }        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
