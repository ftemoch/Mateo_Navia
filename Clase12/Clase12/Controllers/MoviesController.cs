using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;
using Clase12.ViewModels;

namespace Clase12.Controllers
{
	public class MoviesController : Controller
	{
		private ApplicationDbContext _context;
		public MoviesController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		//GET: Movie
		public ViewResult ListaMovies()
		{
			//var Movies = GetMovies();
			var Movies = _context.Movies.ToList();
			return View(Movies);

		}
		public ActionResult Details(int id)
		{
			//var movies = GetMovies().SingleOrDefault(c => c.ID == id);
			var movies = _context.Movies.SingleOrDefault(c => c.ID == id);
			if (movies == null)
				return HttpNotFound();
			return View(movies);
		}

		public ActionResult Edit(int id)
		{
			//var movies = GetMovies().SingleOrDefault(c => c.ID == id);
			var movies = _context.Movies.SingleOrDefault(c => c.ID == id);

			if (movies == null)
				return HttpNotFound();
			var viewModel = new NewPeliculaViewModel
			{
				Movie = movies,
				TipoPeliculas = _context.TipoPeliculas.ToList()
			};
			return View("Genero", viewModel);
		}

		public ActionResult Eliminar(int id)
		{

			var movie = _context.Movies.SingleOrDefault(c => c.ID == id);

			if (movie == null)
				return HttpNotFound();
			else
			{
				_context.Movies.Remove(movie);
				_context.SaveChanges();
			}
			return RedirectToAction("ListaMovies", "Movies");
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				//new Movie {ID=1, Nombre= "Detras del ultimo no hay nadie"},
				//new Movie {ID=2, Nombre= "Mano peluda"}
			};
		}

		public ActionResult Genero()
		{
			var tipoPeliculas = _context.TipoPeliculas.ToList();
			var viewModel = new NewPeliculaViewModel
			{
				TipoPeliculas = tipoPeliculas
			};
			return View(viewModel);
		}

		[HttpPost]
		public ActionResult Create(Movie movie)
		{
			if (movie.ID == 0)
				_context.Movies.Add(movie);
			else
			{
				var movieEnBd = _context.Movies.Single(c => c.ID == movie.ID);
				movieEnBd.Nombre = movie.Nombre;
				movieEnBd.Genero = movie.Genero;
				movieEnBd.IdTipoPelicula = movie.IdTipoPelicula;
				movieEnBd.tipoPelicula = movie.tipoPelicula;
			}
			_context.SaveChanges();
			return RedirectToAction("ListaMovies", "Movies");
		}		
	}
}