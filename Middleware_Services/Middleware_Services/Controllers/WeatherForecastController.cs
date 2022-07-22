using Microsoft.AspNetCore.Mvc;
using Middleware_Services.Services;

namespace Middleware_Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController(IMessagingService messageService)
        {
            _messageService = messageService ?? throw new ArgumentException(nameof(messageService));
        }

        private readonly IMessagingService _messageService;

        [HttpPost]
        public ActionResult SendMessage()
        {
            _messageService.SendMessage("Hello!");
            return Ok();
        }
    }
}