using Clean.Architecture.Core.Abstractions.Messaging;
using Clean.Architecture.Core.Abstractions.Errors;
using Clean.Architecture.Core.common;


namespace Clean.Architecture.UseCases.User.Commands.UpdateUserInformation
{
    public class UpdateUserInformationCommandHandler : ICommandHandler<UpdateUserInformationCommand>
    {
        public async Task<Result> Handle(UpdateUserInformationCommand request, CancellationToken cancellationToken)
        {

            return Result.Failure(AuthenticationErrors.InvalidCredentials);
        }
    }
}