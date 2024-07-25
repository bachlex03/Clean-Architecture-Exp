using Microsoft.AspNetCore.Mvc;
using MediatR;
using Clean.Architecture.UseCases.User.Commands.UpdateUserInformation;
using Clean.Architecture.Core.common;
using Clean.Architecture.Contracts.Authentication;
using Clean.Architecture.Core.Abstractions.Errors;

namespace Clean.Architecture.Web.Controllers
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController : ApiController
    {
        private readonly ISender _sender;

        public UserController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<Result> GetUsers(CancellationToken cancellationToken)
        {
            var command = new UpdateUserInformationCommand();

            Result result = await _sender.Send(command, cancellationToken);

            return result.IsSuccess ? Result.Success() : Result.Failure(AuthenticationErrors.InvalidCredentials);
        }

        [HttpGet("{id}")]
        public async Task<Result> GetUserById(int id)
        {
            var command = new UpdateUserInformationCommand();

            Result result = await _sender.Send(command);

            return Result.Failure(AuthenticationErrors.InvalidCredentials);
        }
    }
}