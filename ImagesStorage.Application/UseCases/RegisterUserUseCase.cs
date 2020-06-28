using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;
using ImagesStorage.Application.Interfaces.Repositories;
using ImagesStorage.Application.Interfaces.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.UseCases
{
    public class RegisterUserUseCase : IRegisterUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(RegisterUserRequest message, IOutputPort<RegisterUserResponse> outputPort)
        {
            var response = await _userRepository.CreateUserAsync(new User(message.FirstName, message.LastName, message.Email, message.UserName), message.Password);
            outputPort.Handle(response.Success ? new RegisterUserResponse(response.Id, true) : new RegisterUserResponse(response.Errors.Select(x => x.Description)));
            return response.Success;
        }
    }
}
