using EduSpark.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduSpark.API.Controllers
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
        private readonly EduSparkDbContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, EduSparkDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
           var courses = _context.Courses.ToList();
            return Ok(courses);
        }
    }
}
