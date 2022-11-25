using InterviewStuff1.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterviewStuff1.Controllers;
[ApiController]
[Route("[controller]")]
public class TemperatureController : ControllerBase
{
    private readonly ITemperatureService _temperatureService;
    private readonly ILogger<WeatherForecastController> _logger;

    public TemperatureController(ITemperatureService temperatureService, ILogger<WeatherForecastController> logger)
    {
        _temperatureService = temperatureService;
        _logger = logger;
    }

    [HttpGet]
    public decimal Post(decimal value, int type)
    {
        return _temperatureService.ConvertTemperature(value, type);
    }
}