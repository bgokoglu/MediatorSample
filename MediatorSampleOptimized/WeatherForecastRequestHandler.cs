using Mediator;

namespace MediatorSampleOptimized;

public class WeatherForecastRequestHandler : IRequestHandler<WeatherForecastRequest, IEnumerable<WeatherForecast>>
{
    private readonly ILogger<WeatherForecastRequestHandler> _logger;
    private readonly IMediator _mediator;
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    public WeatherForecastRequestHandler(ILogger<WeatherForecastRequestHandler> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }
    
    public async ValueTask<IEnumerable<WeatherForecast>> Handle(WeatherForecastRequest request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("processing the request");
        var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            City = request.City,
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        });
        _logger.LogInformation("finished processing the request");

        _mediator.Publish(new Notification1(), cancellationToken);
        _mediator.Publish(new Notification2(), cancellationToken);
        
        return result;
    }
}