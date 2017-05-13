using Microsoft.AspNetCore.Mvc;

namespace AutoLogistic.Controllers
{
    public class ShippingController : Controller
    {
        [Route("Shipping")]
        public IActionResult Shipping()
        {
            return View();
        }

        [Route("ShippingReport")]
        public IActionResult ShippingReport()
        {
            return View();
        }
    }
}