using Mediator;

namespace MediatorSampleOptimized;

public class WeatherForecastRequest : IRequest<IEnumerable<WeatherForecast>>
{
    public string City { get; set; }
}