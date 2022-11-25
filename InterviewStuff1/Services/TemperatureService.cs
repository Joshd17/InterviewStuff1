using InterviewStuff1.Domain;
using InterviewStuff1.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterviewStuff1.Controllers;
[ApiController]
[Route("[controller]")]
public class TemperatureService : ITemperatureService
{
    public decimal ConvertTemperature(decimal temperature, int type)
    {
        return type switch
        {
            0 => Temperature.FromCelcius(temperature).Farenheit,
            1 => Temperature.FromF(temperature).Celcius,
            _ => throw new NotImplementedException($"Temperature type {type} not implemented")
        };
    }
}

