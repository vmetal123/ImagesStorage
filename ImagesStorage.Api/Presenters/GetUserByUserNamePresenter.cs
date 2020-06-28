using ImagesStorage.Api.Serialization;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Api.Presenters
{
    public class GetUserByUserNamePresenter : IOutputPort<GetUserByUserNameResponse>
    {
        public JsonContentResult Content { get; set; }

        public GetUserByUserNamePresenter()
        {
            Content = new JsonContentResult();
        }
        public void Handle(GetUserByUserNameResponse response)
        {
            Content.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            Content.Content = JsonSerializer.SerializeObject(response);
        }
    }
}
