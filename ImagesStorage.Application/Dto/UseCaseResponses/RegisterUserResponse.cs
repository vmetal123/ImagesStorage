using ImagesStorage.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.UseCaseResponses
{
    public class RegisterUserResponse: UseCaseResponseMessage
    {
        public string Id { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public RegisterUserResponse(IEnumerable<string> errors, bool success = false, string message = null): base(success, message)
        {
            Errors = errors;
        }

        public RegisterUserResponse(string id, bool success = false, string message = null): base(success, message)
        {
            Id = id;
        }
    }
}
