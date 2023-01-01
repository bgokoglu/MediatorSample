using MediatR;

namespace MediatorSample;

public class WeatherForecastRequest : IRequest<IEnumerable<WeatherForecast>>
{
    public string City { get; set; }
}