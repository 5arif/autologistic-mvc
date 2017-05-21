using Microsoft.AspNetCore.Mvc;

namespace AutoLogistic.Controllers
{
    public class DeliveringController : Controller
    {
        [Route("Delivering")]
        public IActionResult Delivering()
        {
            return View();
        }

        [Route("DeliveringReport")]
        public IActionResult DeliveringReport()
        {
            return View();
        }
    }
}