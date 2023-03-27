using ErpCore.Business.Logic.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpCore.Business.Logic.Validate
{
    public class RegisterValidator : AbstractValidator<RegisterModel>
    {
        public RegisterValidator() { }
    }
}
