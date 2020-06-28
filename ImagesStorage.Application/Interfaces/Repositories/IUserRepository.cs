using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Dto.Repositories;
using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Helpers;
using System.Threading.Tasks;

namespace ImagesStorage.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<CreateUserResponse> CreateUserAsync(User user, string password);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByIdAsync(string userId);
        Task<ImagesStorage.Application.Dto.UseCaseResponses.GetUserByUserNameResponse> GetUserByUsernameAsync(string username);
        Task<GetUsersResponse> GetUsersAsync(GetUsersRequest queryFilter);
    }
}
