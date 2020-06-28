using AutoMapper;
using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Dto.Repositories;
using ImagesStorage.Application.Dto.UseCaseRequests;
using ImagesStorage.Application.Dto.UseCaseResponses;
using ImagesStorage.Application.Helpers;
using ImagesStorage.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagesStorage.Infrastructure.Identity
{
    public class UserRepository: IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse> CreateUserAsync(User user, string password)
        {
            var appUser = _mapper.Map<ApplicationUser>(user);

            var result = await _userManager.CreateAsync(appUser, password);

            return new CreateUserResponse(appUser.Id.ToString(), result.Succeeded, result.Succeeded ? null : result.Errors.Select(x => new Error(x.Code, x.Description)));
        }

        public async Task<User> GetUserByIdAsync(string userId)
        {
            return _mapper.Map<User>(await _userManager.FindByIdAsync(userId));
        }

        public async Task<ImagesStorage.Application.Dto.UseCaseResponses.GetUserByUserNameResponse> GetUserByUsernameAsync(string username)
        {
            var user = _mapper.Map<User>(await _userManager.FindByNameAsync(username));

            if(user is null)
            {
                return new ImagesStorage.Application.Dto.UseCaseResponses.GetUserByUserNameResponse(new List<string> { "User not found." }, user is null ? false : true, user is null ? "User not found." : null);
            }

            return new ImagesStorage.Application.Dto.UseCaseResponses.GetUserByUserNameResponse(user, user is null ? false : true, user is null ? "User not found." : null);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return _mapper.Map<User>(await _userManager.FindByEmailAsync(email));
        }

        public async Task<GetUsersResponse> GetUsersAsync(GetUsersRequest queryFilter)
        {
            var source = _userManager.Users;

            if(!string.IsNullOrEmpty(queryFilter.SearchTerm))
            {
                source = source.Where(x => x.UserName.Contains(queryFilter.SearchTerm) || x.Email.Contains(queryFilter.SearchTerm));
            }

            var users = _mapper.Map<IEnumerable<User>>(source.AsEnumerable());

            var pagedList = PagedList<User>.Create(users, queryFilter.PageNumber, queryFilter.PageSize);

            return new GetUsersResponse(pagedList, true);
        }
    }
}
