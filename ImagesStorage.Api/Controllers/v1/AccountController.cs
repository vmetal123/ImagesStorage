using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImagesStorage.Api.Models.Requests;
using ImagesStorage.Api.Presenters;
using ImagesStorage.Application.Interfaces.UseCases;
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
        private readonly IRegisterUserUseCase _registerUserUseCase;
        private readonly RegisterUserPresenter _registerUserPresenter;
        private readonly GetUserByUserNamePresenter _getUserByUserNamePresenter;
        private readonly IGetUserByUserNameUseCase _getUserByUserNameUseCase;
        private readonly IGetUsersUseCase _getUsersUseCase;
        private readonly GetUsersPresenter _getUsersPresenter;

        public AccountController(
            IRegisterUserUseCase registerUserUseCase, 
            RegisterUserPresenter registerUserPresenter,
            GetUserByUserNamePresenter getUserByUserNamePresenter,
            IGetUserByUserNameUseCase getUserByUserNameUseCase,
            IGetUsersUseCase getUsersUseCase,
            GetUsersPresenter getUsersPresenter
        )
        {
            _registerUserUseCase = registerUserUseCase;
            _registerUserPresenter = registerUserPresenter;
            _getUserByUserNamePresenter = getUserByUserNamePresenter;
            _getUserByUserNameUseCase = getUserByUserNameUseCase;
            _getUsersUseCase = getUsersUseCase;
            _getUsersPresenter = getUsersPresenter;
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

        [HttpGet("User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUser([FromQuery] GetUserByUserNameRequest request)
        {
            await _getUserByUserNameUseCase
                .Handle(new Application.Dto.UseCaseRequests.GetUserByUserNameRequest(request.UserName), _getUserByUserNamePresenter);
            return _getUserByUserNamePresenter.Content;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUsers([FromQuery] GetUsersRequest request)
        {
            await _getUsersUseCase
                .Handle(new Application.Dto.UseCaseRequests.GetUsersRequest(request.PageNumber, request.PageSize, request.SearchTerm), _getUsersPresenter);
            return _getUsersPresenter.Content;
        }
    }
}
