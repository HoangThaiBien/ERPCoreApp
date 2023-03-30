using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Dtos
{
    public class RegisterModel
    {
       /* [RegularExpression(@"^\d{10}$")]
        [Required]
        public string? PhoneNumber { get; set; } = null;*/
        [EmailAddress]
        [Required]
        public string? Email { get; set; } = null;
        [Required]
        public string? Password { get; set; } = null;
        [Required]
        public string? PasswordConfirmed { get; set; } = null;

    }
}
