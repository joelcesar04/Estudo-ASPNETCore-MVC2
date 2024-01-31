using Microsoft.AspNetCore.Mvc;

namespace JcIO.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("buscar")]
        public IActionResult Busca()
        {
            return View();
        }
    }
}
