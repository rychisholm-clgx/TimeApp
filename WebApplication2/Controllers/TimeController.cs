using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/time")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        //gets the current time and date
        [HttpGet]
        public string ListTimeZone()
        {
            return DateTime.Now.ToString();
        }
    }
}
