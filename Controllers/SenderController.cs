using Microsoft.AspNetCore.Mvc;

namespace PTPDelivery.Server.Controllers
{
    public class SenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
