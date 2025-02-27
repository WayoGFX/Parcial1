using Microsoft.AspNetCore.Mvc;
using Parcial1.Models;

namespace Parcial1.Controllers
{
    public class CaidaController : Controller
    {
        //base tologger
        private readonly ILogger<HomeController> _logger;

        public CaidaController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        // se crea la función para calcular la caída
        public IActionResult CaidaCalcular(Caida objCaida)
        {
            // se hace una condicional para no tener errores
            if (objCaida.Dato > 0)
            {
                // la formula de caída libre es t = sqrt de ( 2 * h  / g )
                objCaida.Result = (Math.Sqrt((objCaida.Dato * 2) / 9.8)) + " segundos";
            } else
            {
                // si hay un dato malo se pone error
                objCaida.Result = "ERROR, debe ingresar número mayor a 0";
            }

            // se retorna la vista
            return View("Index", objCaida);
        }
    }
}
