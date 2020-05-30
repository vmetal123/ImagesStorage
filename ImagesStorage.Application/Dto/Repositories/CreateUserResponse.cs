using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.Repositories
{
    public class CreateUserResponse: BaseResponse
    {
        public string Id { get; set; }

        public CreateUserResponse(string id, bool success = false, IEnumerable<Error> errors = null): base(success, errors)
        {
            Id = id;
        }
    }
}
