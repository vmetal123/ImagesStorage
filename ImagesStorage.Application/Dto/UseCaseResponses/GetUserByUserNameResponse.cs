using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.UseCaseResponses
{
    public class GetUserByUserNameResponse: UseCaseResponseMessage
    {
        public User User { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public GetUserByUserNameResponse(User user, bool success = false, string message = null): base(success, message)
        {
            User = user;
        }

        public GetUserByUserNameResponse(IEnumerable<string> errors, bool success = false, string message = null) : base(success, message)
        {
            Errors = errors;
        }
    }
}
