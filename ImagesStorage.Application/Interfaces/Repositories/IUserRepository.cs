using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Dto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<CreateUserResponse> CreateUserAsync(User user, string password);
    }
}
