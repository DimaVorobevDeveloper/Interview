// using Interview.WithLinqToDb.Data.DbRepositories.Rds;
using Interview.WithLinqToDb.Data.Standard.DbRepositories.KPP;
using Microsoft.AspNetCore.Mvc;

namespace Interview.WithLinqToDb.WebApi.Controllers
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
        private readonly KppRepository _rds;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, KppRepository rds)
        {
            _logger = logger;
            _rds = rds;
        }

        [HttpGet]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var t1 = await _rds.GetActionEventsAsync();

            var t2 = t1.Count;
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}