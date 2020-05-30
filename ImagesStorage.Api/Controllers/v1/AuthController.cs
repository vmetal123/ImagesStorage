using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImagesStorage.Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ImagesStorage.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        public AuthController()
        {

        }
    }
}
