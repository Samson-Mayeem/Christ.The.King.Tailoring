using Mark.Up.Fashion.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Mark.Up.Fashion.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdController : ControllerBase
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<ApiUser> Get()
        {
            return null;
        }
    }
}