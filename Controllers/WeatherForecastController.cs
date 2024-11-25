using Microsoft.AspNetCore.Mvc;
using TestApi4ITB_2.Models;

namespace TestApi4ITB_2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // GET : "test"
    // localhost:5214/WeatherForecast/test

    readonly string[] summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet("test/{count}")]
    public IEnumerable<WeatherForecast> GetForecast(int count = 5)
    {
        var forecast = Enumerable.Range(1, count).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
        return forecast;
    }
}
