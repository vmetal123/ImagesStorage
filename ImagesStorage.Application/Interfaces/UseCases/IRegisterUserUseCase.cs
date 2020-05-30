using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Interfaces.UseCases
{
    public interface IRegisterUserUseCase: IUseCaseRequestHandler<RegisterUserRequest, RegisterUserResponse>
    {
        
    }
}
