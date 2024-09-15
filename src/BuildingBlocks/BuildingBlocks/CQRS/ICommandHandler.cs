using MediatR;

namespace BuildingBlocks.CQRS;

public interface ICommandHandler<in TCommon> 
    : ICommandHandler<TCommon, Unit>
    where TCommon : ICommand<Unit>
{
}

public interface ICommandHandler<in TCommand, TResponse> 
    : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
    where TResponse : notnull
{
}
