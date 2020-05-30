using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.UseCaseRequests
{
    public class RegisterUserRequest: IUseCaseRequest<RegisterUserResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public RegisterUserRequest(string firstName, string lastName, string email, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = userName;
            Password = password;
        }
    }
}
