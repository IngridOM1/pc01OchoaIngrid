using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ppc01.Controllers
{
    public class TarjetaController : Controller
    {
        private readonly ILogger<TarjetaController> _logger;

        public TarjetaController(ILogger<TarjetaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}



