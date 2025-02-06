using Microsoft.AspNetCore.Mvc;

namespace ChamCong.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
