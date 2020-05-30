using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImagesStorage.Api.Models.Requests;
using ImagesStorage.Api.Presenters;
using ImagesStorage.Application.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace ImagesStorage.Api.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly RegisterUserUseCase _registerUserUseCase;
        private readonly RegisterUserPresenter _registerUserPresenter;

        public AccountController(RegisterUserUseCase registerUserUseCase, RegisterUserPresenter registerUserPresenter)
        {
            _registerUserUseCase = registerUserUseCase;
            _registerUserPresenter = registerUserPresenter;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterUserRequest request)
        {
            await _registerUserUseCase
                .Handle(new Application.Dto.UseCaseRequests.RegisterUserRequest(request.FirstName, request.LastName, request.Email, request.UserName, request.Password), _registerUserPresenter);
            return _registerUserPresenter.Content;
        }
    }
}
