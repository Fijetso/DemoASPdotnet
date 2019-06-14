using Microsoft.AspNetCore.Mvc;

namespace server.Controllers {
    public class PostController : BaseController {
        [HttpGet]
        public ActionResult<string> index () {
            return "Hello from Demo ASPDOTNET";
        }
    }
}