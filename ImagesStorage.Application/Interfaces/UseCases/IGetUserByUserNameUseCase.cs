using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;

namespace ImagesStorage.Application.Interfaces.UseCases
{
    public interface IGetUserByUserNameUseCase: IUseCaseRequestHandler<GetUserByUserNameRequest, GetUserByUserNameResponse>
    {
        
    }
}
