using MediatR;

namespace MediatorSample;

public class Notification1Handler : INotificationHandler<Notification1>
{
    private readonly ILogger<Notification1Handler> _logger;
    private readonly IMediator _mediator;

    public Notification1Handler(ILogger<Notification1Handler> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    public async Task Handle(Notification1 notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("handling notification {id}" ,notification.Id);
         await Task.Delay(100, cancellationToken);
        _logger.LogInformation("finished handling notification {id}" ,notification.Id);
    }
}