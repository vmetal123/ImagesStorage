using FluentValidation;
using ImagesStorage.Api.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Api.Models.Validation
{
    public class GetUserByUserNameRequestValidator: AbstractValidator<GetUserByUserNameRequest>
    {
        public GetUserByUserNameRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().NotNull();
        }
    }
}
