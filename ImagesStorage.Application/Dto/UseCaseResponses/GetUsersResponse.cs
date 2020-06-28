using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Helpers;
using ImagesStorage.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Dto.UseCaseResponses
{
    public class GetUsersResponse: UseCaseResponseMessage
    {
        public PagedList<User> Users { get; set; }

        public GetUsersResponse(PagedList<User> users, bool success = false, string message = null): base(success, message)
        {
            Users = users;
        }
    }
}
