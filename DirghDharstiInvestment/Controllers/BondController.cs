using Microsoft.AspNetCore.Mvc;

namespace DirghDharstiInvestment.Controllers
{
    public class BondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
