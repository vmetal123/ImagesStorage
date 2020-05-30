using AutoMapper;
using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Application.Dto.Repositories;
using ImagesStorage.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
