using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileProjectManagement.Context;
using AgileProjectManagement.Context.Entity;
using AgileProjectManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AgileProjectManagement.Controllers
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

        private ProjectRepository projectRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger  , ProjectDbContext context)
        {
            _logger = logger;
            projectRepository = new ProjectRepository(context);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [Route("/test")]
        [HttpGet]
        public Project Test()
        {
            var project = projectRepository.GetById(1);
            return project;
        }
    }
}
