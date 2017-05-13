using Microsoft.AspNetCore.Mvc;

namespace AutoLogistic.Controllers
{
    public class StuffingController : Controller
    {
        [Route("Stuffing")]
        public IActionResult Stuffing()
        {
            return View();
        }

        [Route("StuffingReport")]
        public IActionResult StuffingReport()
        {
            return View();
        }
    }
}