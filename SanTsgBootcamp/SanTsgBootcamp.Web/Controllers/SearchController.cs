using Microsoft.AspNetCore.Mvc;
using SanTsgBootcamp.Data;
using System.Linq;

namespace SanTsgBootcamp.Web.Controllers
{

    public class SearchController : Controller
    {
        private readonly CityDbContext _context;
      
        public SearchController(CityDbContext cityDbContext)
        {
            _context = cityDbContext;
        }
        public IActionResult Index(string? id)
        {
            var query = from s in _context.CityModels select s;
            if (!string.IsNullOrEmpty(id))
            {
                query = _context.CityModels.Where(p => p.CityName.StartsWith(id));

            }
            return View(query.ToList());
        }
    }
}



