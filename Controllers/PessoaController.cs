using Microsoft.AspNetCore.Mvc;
using Init.Models;

namespace Init.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            Pessoa pessoa1 = new Pessoa()
            {
                Id = 1,
                Nome= "Eduarda Brisch Dalmas",
                CPF = "041.985.790-75",
                Telefone = "51 999002828",
                Email = "eduardadalmas@ienh.com.br",
            };

            return View(pessoa1);
        }
    }
}