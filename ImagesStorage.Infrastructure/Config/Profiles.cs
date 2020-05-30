using AutoMapper;
using ImagesStorage.Application.Domain.Entities;
using ImagesStorage.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Infrastructure.Config
{
    public class Profiles: Profile
    {
        public Profiles()
        {
            CreateMap<ApplicationUser, User>();
            CreateMap<User, ApplicationUser>();
        }
    }
}
