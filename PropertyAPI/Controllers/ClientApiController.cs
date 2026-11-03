using Microsoft.AspNetCore.Mvc;

namespace PropertyAPI.Controllers
{
    public class ClientApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
