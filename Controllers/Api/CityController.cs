using Microsoft.AspNetCore.Mvc;
using AutoLogistic.Models.Master;
using System.Linq;
using AutoLogistic.Data;
using AutoLogistic.Data.Common;

namespace AutoLogistic.Controllers.Api
{
    [Route("api/[controller]")]
    public class CityController : Controller
    {
        private ApplicationDbContext _context;
        private Repository<City> _cityRepository;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
            _cityRepository = new Repository<City>(_context);
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _cityRepository.GetQuery().Select(e => new
            {
                e.CityId,
                e.CityName
            });

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] City item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _cityRepository.Create(item);
            return Ok(item);
        }
    }
}
