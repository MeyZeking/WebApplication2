using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class ClientController : Controller
    {

        [HttpGet]
        public IActionResult CreateClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateClient(CreateClientViewModel client)
        {
            return View();
        }

        



    }
}
