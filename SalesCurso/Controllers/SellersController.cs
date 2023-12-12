using Microsoft.AspNetCore.Mvc;

namespace SalesCurso.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
