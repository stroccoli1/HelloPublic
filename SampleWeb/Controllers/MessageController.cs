using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MessageManager;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IConfiguration configuration;
        MessageManager.Manager manager = new Manager();
        public MessageController(IConfiguration Configuration)
        {
            configuration = Configuration;
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
           //For Data Aware: hw.DbConnection(configuration.GetConnectionString("myDb1"));
            return new string[] { manager.DefaultMessage };
        }
        /************************************************* '
      * Data Aware not implemented - add values:
      * *******************************************************/
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return manager.GetMetssage(id);
        }
     
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
