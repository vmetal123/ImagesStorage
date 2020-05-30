using FluentValidation;
using ImagesStorage.Api.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Api.Models.Validation
{
    public class RegisterUserRequestValidator : AbstractValidator<RegisterUserRequest>
    {
        public RegisterUserRequestValidator()
        {
            RuleFor(x => x.FirstName).Length(2, 30);
            RuleFor(x => x.LastName).Length(2, 30);
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.UserName).Length(5, 32);
            RuleFor(x => x.Password).Length(5, 16);
        }
    }
}
