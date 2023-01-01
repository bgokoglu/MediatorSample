using Mediator;

namespace MediatorSampleOptimized;

public class Notification2Handler : INotificationHandler<Notification2>
{
    private readonly ILogger<Notification2Handler> _logger;

    public Notification2Handler(ILogger<Notification2Handler> logger)
    {
        _logger = logger;
    }

    public async ValueTask Handle(Notification2 notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("handling notification {id}" ,notification.Id);
        await Task.Delay(100, cancellationToken);
        _logger.LogInformation("finished handling notification {id}" ,notification.Id);
    }
}