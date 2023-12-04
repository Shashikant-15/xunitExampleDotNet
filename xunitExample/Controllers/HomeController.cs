using Microsoft.AspNetCore.Mvc;

namespace xunitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "I am in Home";
        }
    }
}
