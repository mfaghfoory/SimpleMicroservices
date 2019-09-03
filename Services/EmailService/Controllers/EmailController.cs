using System.Threading.Tasks;
using EmailService.Models;
using MainWebApp.Models.Commands;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace EmailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase, IConsumer<MessageCommand>
    {
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Email value)
        {
            //you send email here
            return Ok("Your email sent :)");
        }

        public async Task Consume(ConsumeContext<MessageCommand> context)
        {
            await context.RespondAsync(new MessageCommand { Message = "Pong" });
        }
    }
}
