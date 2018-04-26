using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class PortfolioController : Controller
    {
        //route to home
        [HttpGet("home")]
        public IActionResult Home()
        {
            return View("Home");
        }

        //route to projects
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        //route to contact
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}