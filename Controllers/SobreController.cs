using Microsoft.AspNetCore.Mvc;
using Init.Models; 

namespace Init.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            Sobre sobre1 = new Sobre()
            {
                Sabe1 = "Javascript ",
                Sabe2= "HTML5/Css",
                Sabe3 = "C#",
                Sabe4 = "Node",
                Sabe5 = "React",
                Sabe6 = "MySQL/Postgree",
            };

            return View(sobre1);
        }
    }
}