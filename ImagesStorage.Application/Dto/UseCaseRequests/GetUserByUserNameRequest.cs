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
    public class GetUserByUserNameRequest: IUseCaseRequest<GetUserByUserNameResponse>
    {
        public string UserName { get; set; }

        public GetUserByUserNameRequest(string userName)
        {
            UserName = userName;
        }
    }
}
