using Microsoft.AspNetCore.Mvc;

namespace DesingPatternChainOfResponsibilityAkademiPlus.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
