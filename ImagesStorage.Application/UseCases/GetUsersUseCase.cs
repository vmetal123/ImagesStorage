using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;
using ImagesStorage.Application.Interfaces.Repositories;
using ImagesStorage.Application.Interfaces.UseCases;
using System.Threading.Tasks;

namespace ImagesStorage.Application.UseCases
{
    public class GetUsersUseCase: IGetUsersUseCase
    {
        private readonly IUserRepository _userRepository;

        public GetUsersUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Handle(GetUsersRequest message, IOutputPort<GetUsersResponse> outputPort)
        {
            var response = await _userRepository.GetUsersAsync(message);
            outputPort.Handle(response);
            return response.Success;
        }
    }
}
