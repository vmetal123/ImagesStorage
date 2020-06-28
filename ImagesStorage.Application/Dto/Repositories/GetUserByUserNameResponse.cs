using ImagesStorage.Application.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.Repositories
{
    public class GetUserByUserNameResponse: BaseResponse
    {
        public User User { get; set; }

        public GetUserByUserNameResponse(User user, bool success = false, IEnumerable<Error> errors = null)
        {
            User = user;
        }
    }
}
