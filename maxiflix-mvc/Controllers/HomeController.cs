using System.Diagnostics;
using maxiflix_mvc.Data;
using maxiflix_mvc.Models;
using maxiflix_mvc.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace maxiflix_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MaxiFlixDbContext _context;

        public HomeController(ILogger<HomeController> logger, MaxiFlixDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async  Task<IActionResult> Index()
        {
            var peliculas = await _context.Peliculas
                .ToListAsync();

            var media = await _context.Media
                .Include(m => m.Tipo)
                .Where(m => m.Tipo.Descripcion == "Poster")
                .ToListAsync();

            var homeModel = new HomeViewModel { Peliculas = peliculas, Media = media };

            return View(homeModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
