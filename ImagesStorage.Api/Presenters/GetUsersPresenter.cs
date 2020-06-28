using ImagesStorage.Api.Serialization;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Api.Presenters
{
    public class GetUsersPresenter : IOutputPort<GetUsersResponse>
    {
        public JsonContentResult Content { get; set; }

        public GetUsersPresenter()
        {
            Content = new JsonContentResult();
        }
        public void Handle(GetUsersResponse response)
        {
            Content.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            Content.Content = JsonSerializer.SerializeObject(response);
        }
    }
}
