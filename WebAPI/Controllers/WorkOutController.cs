using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [Route("api/workout")]
    [ApiController]
    public class WorkOutController : ControllerBase
    {
        private readonly ILogger<WorkOutController> _logger;
        private IRepositoryWrapper _repoWrapper;
        public WorkOutController(IRepositoryWrapper repoWrapper, ILogger<WorkOutController> logger)
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
        }

        // GET: api/WorkOut
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WorkOut/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WorkOut
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/WorkOut/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
