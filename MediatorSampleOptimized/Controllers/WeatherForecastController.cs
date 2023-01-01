using Mediator;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSampleOptimized.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get(string city = "London")
    {
        var weatherForecastRequest = new WeatherForecastRequest { City = city };
        _logger.LogInformation("sending to mediatr");
        var result = await _mediator.Send(weatherForecastRequest);
        _logger.LogInformation("received from mediatr");
        return Ok(result);
    }
}