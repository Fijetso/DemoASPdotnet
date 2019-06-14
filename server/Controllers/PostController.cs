using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        [HttpGet]
        public ActionResult<string> index()
        {
            return "Hello from Demo ASPDOTNET";
        }
    }
}