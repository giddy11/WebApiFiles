using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [ApiController]

    //adding multiple resources
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()                         //the attribute is Get
        {
            return "Hello from Get";                //this is known as the resource and we need to map a url to the resource by using the ROUTE
        }
    }
}
