using Microsoft.AspNetCore.Mvc;

namespace JcIO.Site.Areas.Vendas.Controllers
{
    [Area("vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
