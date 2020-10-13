using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.nhrappdata;
using Entities.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace nhr_api_agent.Controllers
{
    [ApiController]
    /*[Route("[controller]")]*/
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepository<Employee> employeeRepository;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository<Employee> employeeRepository)
        {
            _logger = logger;
            this.employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("/")]
        public IEnumerable<Employee> Get()
        {
            // Error: HTTP ERROR 500 => Debugging for P163 Servant
            var employees = employeeRepository.FindAll();
            return employees;
            /*var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();*/
        }
    }
}
