using System;
using System.Collections.Generic;
using CPBC.DotNetCore.Common.Facade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CPBC.DotNetCore.Service.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly ILogger _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            try
            {
                _logger.LogInformation(LoggingEvents.GetItem, "Getting item");
                
                return new string[] { "value1", "value2" };

            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.GetItemNotFound,ex, "Item not Found.. !!");

            }

            return new string[] { };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
