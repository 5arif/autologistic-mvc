using Microsoft.AspNetCore.Mvc;

namespace AutoLogistic.Controllers
{
    public class MasterController : Controller
    {
        [Route("Carrier")]
        public IActionResult Carrier()
        {
            return View();
        }

        [Route("Driver")]
        public IActionResult Driver()
        {
            return View();
        }

        [Route("Rack")]
        public IActionResult Rack()
        {
            return View();
        }

        [Route("Model")]
        public IActionResult ItemModel()
        {
            return View();
        }

        [Route("Type")]
        public IActionResult ItemType()
        {
            return View();
        }

        [Route("City")]
        public IActionResult City()
        {
            return View();
        }
        
        [Route("Customer")]
        public IActionResult Customer()
        {
            return View();
        }

        [Route("PickupArea")]
        public IActionResult PickupArea()
        {
            return View();
        }

        [Route("Trucker")]
        public IActionResult Trucker()
        {
            return View();
        }
    }
}
