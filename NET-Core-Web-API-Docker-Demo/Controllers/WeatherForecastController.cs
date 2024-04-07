using Microsoft.AspNetCore.Mvc;

namespace NET_Core_Web_API_Docker_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieves an array of weather forecasts.
        /// </summary>
        /// <returns>An array of <see cref="WeatherForecast"/> objects representing the weather forecast for the next 5 days.</returns>
        /// <remarks>
        /// This method generates an array of <see cref="WeatherForecast"/> objects, each representing the weather forecast for a specific day.
        /// The temperature for each forecast is randomly generated within the range of -20 to 55 degrees Celsius.
        /// The date for each forecast is calculated based on the current date and the index of the forecast.
        /// The summary for each forecast is randomly selected from a predefined list of weather summaries.
        /// </remarks>
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

        
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
