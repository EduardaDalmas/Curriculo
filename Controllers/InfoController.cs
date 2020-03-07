using Microsoft.AspNetCore.Mvc;
using Init.Models; 

namespace Init.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            Info info1 = new Info()
            {
                Cargo = "desenvolvedora full-stack",
                Estudo1 = "Ensino Fundamental concluído",
                Estudo2 = "Ensino Médio concluído",
                Estudo3 = "Técnico em Informática na IENH",
                Estudo4 = "Curso de desenvolvimento Full-Stack na GrowDev",
                Estudo5 = "Inglês Básico na Wizard",
                Estágio = "Estagiária na empresa BCS automação",
            };

            return View(info1);
        }
    }
}