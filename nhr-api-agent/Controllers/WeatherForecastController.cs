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
    [Route("[controller]")]
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
        public IEnumerable<Employee> Get()
        {
            var employees = employeeRepository.FindAll();
            return employees;
        }
    }
}
