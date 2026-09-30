using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management_System_API.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
