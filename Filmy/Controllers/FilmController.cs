using Filmy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Filmy.Controllers
{
    public class FilmController : Controller
    {
        private static IList<Film> movies = new List<Film>
        {
            new Film() { Id = 1, Name = "Film1", Description = "Opis", Price = 20 },
            new Film() { Id = 2, Name = "Film2", Description = "Opis2", Price = 25 }
        };
        // GET: FilmController
        public ActionResult Index()
        {
            return View(movies);
        }

        // GET: FilmController/Details/5
        public ActionResult Details(int id)
        {
            return View(movies.FirstOrDefault(x => x.Id == id));
        }

        // GET: FilmController/Create
        public ActionResult Create()
        {
            return View(new Film());
        }

        // POST: FilmController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            film.Id = movies.Count + 1;
            movies.Add(film);
            
            return RedirectToAction(nameof(Index));
            
        }

        // GET: FilmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FilmController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Film editfilm)
        {
            Film film = movies.FirstOrDefault(x => x.Id == id);
            editfilm.Name = film.Name;
            editfilm.Description = film.Description;
            editfilm.Price = film.Price;
            return RedirectToAction(nameof(Index));
        }

        // GET: FilmController/Delete/5
        public ActionResult Delete(Film film)
        {
            return View();
        }

        // POST: FilmController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Film film = movies.FirstOrDefault(x => x.Id == id);
            movies.Remove(film);
            return RedirectToAction(nameof(Index));
        }
    }
}
