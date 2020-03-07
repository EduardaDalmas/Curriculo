using Microsoft.AspNetCore.Mvc;
using Init.Models; 

namespace Init.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            Portfolio portfolio1 = new Portfolio()
            {
                Git = "https://github.com/EduardaDalmas",
                Bit= "https://bitbucket.org/EduardaDalmas/profile/repositories",
            };

            return View(portfolio1);
        }
    }
}