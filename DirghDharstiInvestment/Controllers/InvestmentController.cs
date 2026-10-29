using Microsoft.AspNetCore.Mvc;

namespace DirghDharstiInvestment.Controllers
{
    public class InvestmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
