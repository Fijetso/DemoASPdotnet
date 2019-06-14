using Microsoft.AspNetCore.Mvc;

namespace server.Controllers {
    [Route ("api/{controller}")]
    [ApiController]
    public abstract class BaseController : Controller {

    }
}