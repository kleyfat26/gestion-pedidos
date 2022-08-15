using gestionPedidos.Models;
using Microsoft.AspNetCore.Mvc;

namespace gestionPedidos.Controllers
{
    public class FormaPedidoController : Controller
    {
        public readonly gestionpedidoContext _gestionpedidoContext;

        public FormaPedidoController(gestionpedidoContext gestionpedidoContext)
        {
            _gestionpedidoContext = gestionpedidoContext;
        }

        public IActionResult Index()
        {
            DateTime dateNow = new DateTime(2022, 07, 24);

            var poees = _gestionpedidoContext.Poees.Where(p => p.Fechaenvio >= dateNow)
                .OrderBy(p => p.Fechaenvio)
                .ToList();


            return View(poees);
        }
    }
}
