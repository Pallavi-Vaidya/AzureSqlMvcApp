using Microsoft.AspNetCore.Mvc;

namespace AzureSqlMvcApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
