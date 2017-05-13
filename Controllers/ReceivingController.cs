using Microsoft.AspNetCore.Mvc;

namespace AutoLogistic.Controllers
{
    public class ReceivingController : Controller
    {
        [Route("Receiving")]
        public IActionResult Receiving()
        {
            return View();
        }

        [Route("ReceivingReport")]
        public IActionResult ReceivingReport()
        {
            return View();
        }
    }
}