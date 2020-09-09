using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using nhr_api_agent.nhrappdata;

namespace nhr_api_agent.Controllers
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

        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            var dbcontext = new nhrappdataContext();

            using (nhrappdataContext dbContext = new nhrappdataContext())
            {
                IQueryable<Employees> employees = from p in dbContext.Employees
                                                  select p;
                                                  //orderby p.ProductName descending

                Employees[] employeesArray = employees.ToArray();
                return employeesArray;
            }
        }
    }
}
