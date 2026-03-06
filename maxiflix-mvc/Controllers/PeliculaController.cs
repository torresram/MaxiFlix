using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using maxiflix_mvc.Data;
using maxiflix_mvc.Models;
using maxiflix_mvc.Models.ViewModels;

namespace maxiflix_mvc.Controllers
{
    public class PeliculaController : Controller
    {
        private readonly MaxiFlixDbContext _context;

        public PeliculaController(MaxiFlixDbContext context)
        {
            _context = context;
        }

        // GET: Pelicula
        public async Task<IActionResult> Index()
        {
            var maxiFlixDbContext = _context.Peliculas
                .Include(p => p.Director);

            return View(await maxiFlixDbContext.ToListAsync());
        }

        // GET: Pelicula/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Peliculas
                .Include(p => p.Director)
                .FirstOrDefaultAsync(p=> p.Id == id);

            var categorias = await _context.PeliculasCategorias
                .Include(pc => pc.Categoria)
                .Where(pc => pc.PeliculaId == id)
                .ToListAsync();

            var generos = await _context.PeliculasGeneros
                .Include(pg => pg.Genero)
                .Where(pg => pg.PeliculaId == id)
                .ToListAsync();

            var reparto = await _context.PeliculasReparto
                .Include(pr => pr.Reparto)
                .Where(pr => pr.PeliculaId == id)
                .ToListAsync();

            var clasificacion = await _context.PeliculasClasificaciones
                .Include(cp => cp.Clasificacion)
                .FirstOrDefaultAsync(cp => cp.PeliculaId == id);

            var puntuacion = await _context.PeliculasPuntuaciones
                .Where(pp => pp.PeliculaId == id)
                .ToListAsync();

            var media = await _context.Media
                .Include(m => m.Tipo)
                .Where(m => m.PeliculaId == id)
                .ToListAsync();

            double promedio = 0;
            int cantidad = puntuacion.Count;

            if(cantidad > 0)
            {
                promedio = puntuacion.Average(pp =>pp.Puntuacion);
            }

            var pelisModel = new PeliculaViewModel
            {
                Pelicula = pelicula,
                Categorias = categorias,
                Generos = generos,
                Reparto = reparto,
                Clasificacion = clasificacion,
                Puntuacion = promedio,
                CantidadPuntuaciones = cantidad,
                Medias = media
            };

            return View(pelisModel);
        }

        // GET: Pelicula/Create
        public IActionResult Create()
        {
            ViewData["RepartoId"] = new SelectList(_context.Reparto, "Id", "Id");
            return View();
        }

        // POST: Pelicula/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaEstreno,Titulo,MinutosDuracion,Sinopsis,RepartoId")] Peliculas peliculas)
        {
            if (ModelState.IsValid)
            {
                peliculas.Id = Guid.NewGuid();
                _context.Add(peliculas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RepartoId"] = new SelectList(_context.Reparto, "Id", "Id", peliculas.RepartoId);
            return View(peliculas);
        }

        // GET: Pelicula/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas.FindAsync(id);
            if (peliculas == null)
            {
                return NotFound();
            }
            ViewData["RepartoId"] = new SelectList(_context.Reparto, "Id", "Id", peliculas.RepartoId);
            return View(peliculas);
        }

        // POST: Pelicula/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FechaEstreno,Titulo,MinutosDuracion,Sinopsis,RepartoId")] Peliculas peliculas)
        {
            if (id != peliculas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculasExists(peliculas.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RepartoId"] = new SelectList(_context.Reparto, "Id", "Id", peliculas.RepartoId);
            return View(peliculas);
        }

        // GET: Pelicula/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas
                .Include(p => p.Director)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peliculas == null)
            {
                return NotFound();
            }

            return View(peliculas);
        }

        // POST: Pelicula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var peliculas = await _context.Peliculas.FindAsync(id);
            if (peliculas != null)
            {
                _context.Peliculas.Remove(peliculas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculasExists(Guid id)
        {
            return _context.Peliculas.Any(e => e.Id == id);
        }
    }
}
