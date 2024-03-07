using Microsoft.AspNetCore.Mvc;
using bugTracker.Models;

namespace bugTracker.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            var project = new Project() { Name = "Demo" };
            return View(project);
        }
    }
}
