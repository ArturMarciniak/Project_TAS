using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace todo_web_app.Controllers
{
    [Produces("application/json")]
    [Route("api/Dashboard")]
    public class DashboardController : Controller
    {
        // GET: api/Dashboard
        [HttpGet, Authorize]
        public IEnumerable<string> Get()
        {
            //get all
            return new string[] { "value1", "value2" };
        }

        // GET: api/Dashboard/5
        [HttpGet("{id}", Name = "GetDashboard")]
        public string Get(int id)
        {
            //get one by id
            return "value";
        }
        
        // POST: api/Dashboard
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //add task to database
        }
        
        // PUT: api/Dashboard/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            //edit task in database
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //delete
        }
    }
}
