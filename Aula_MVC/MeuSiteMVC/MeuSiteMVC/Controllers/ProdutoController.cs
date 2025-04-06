using Microsoft.AspNetCore.Mvc;

namespace MeuSiteMVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}
