using Microsoft.AspNetCore.Mvc;
using AutoLogistic.Data;
using System.Linq;

namespace AutoLogistic.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context){
            _context = context;
        }

        public JsonResult Index()
        {
            var item = _context.City.ToList();
            return Json(item);
        }
    }
}