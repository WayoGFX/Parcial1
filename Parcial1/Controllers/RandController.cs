using Microsoft.AspNetCore.Mvc;
using Parcial1.Models;

namespace Parcial1.Controllers
{
    public class RandController : Controller
    {
        //base tologger
        private readonly ILogger<HomeController> _logger;

        public RandController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        // se crea la función para calcular la caída
        public IActionResult RandomGenerador(Rand objRand)
        {
            // generar sentencia para números random
            Random random = new Random();

            // asignar valores
            objRand.ResultRandom = random.Next(1, 100);

            // retornar la vista
            return View("Index", objRand);
        }
    }
}
