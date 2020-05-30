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
    public class RegisterUserPresenter : IOutputPort<RegisterUserResponse>
    {
        public JsonContentResult Content { get; set; }

        public RegisterUserPresenter()
        {
            Content = new JsonContentResult();
        }
        public void Handle(RegisterUserResponse response)
        {
            Content.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.BadRequest);
            Content.Content = JsonSerializer.SerializeObject(response);
        }
    }
}
