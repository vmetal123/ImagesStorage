using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;
using ImagesStorage.Application.Interfaces.Repositories;
using ImagesStorage.Application.Interfaces.UseCases;
using System.Linq;
using System.Threading.Tasks;

namespace ImagesStorage.Application.UseCases
{
    public class GetUserByUserNameUseCase : IGetUserByUserNameUseCase
    {
        private readonly IUserRepository _userRepository;

        public GetUserByUserNameUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(GetUserByUserNameRequest message, IOutputPort<GetUserByUserNameResponse> outputPort)
        {
            var response = await _userRepository.GetUserByUsernameAsync(message.UserName);
            outputPort.Handle(response.Success ? new GetUserByUserNameResponse(response.User, true) : new GetUserByUserNameResponse(response.Errors.Select(x=>x)));
            return response.Success;
        }
    }
}
