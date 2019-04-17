using EmailService.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Email value)
        {
            //you send email here
            return Ok("Your email sent :)");
        }
    }
}
