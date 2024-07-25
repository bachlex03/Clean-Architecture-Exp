
using Clean.Architecture.Core.common;
using MediatR;

namespace Clean.Architecture.Core.Abstractions.Messaging
{
    public interface ICommand : IRequest<Result>
    {

    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {

    }
}