using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).MinimumLength(2).WithMessage("İsim en az 2 karakter uzunluğunda olmalıdır.");

            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).MinimumLength(2).WithMessage("İsim en az 2 karakter uzunluğunda olmalıdır.");

            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.UserID).NotEmpty();
            
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MinimumLength(10).WithMessage("Şifre en az 10 karakter uzunluğunda olmalıdır.");
        }
    }
}
