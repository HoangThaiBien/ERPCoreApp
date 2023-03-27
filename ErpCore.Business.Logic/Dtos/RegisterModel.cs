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
        [EmailAddress]
        [Required]
        public string? Email { get; set; } = null;
        [Required]
        public string? Password { get; set; } = null;
        [Required]
        public string? PasswordConfirmed { get; set; } = null;

    }
}
