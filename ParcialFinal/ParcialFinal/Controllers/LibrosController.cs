using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParcialFinal.Models;
using ParcialFinal.ViewModels;

namespace ParcialFinal.Controllers
{
	public class LibrosController : Controller
	{
		private ApplicationDbContext _context;
		public LibrosController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Libro
		public ViewResult Lista()
		{
			//var libros = GetLibros();
			var libros = _context.Libros.ToList();
			return View(libros);
		}

		public ActionResult Details(int id)
		{
			//var libros = GetLibros().SingleOrDefault(c => c.ID == id);
			var libros = _context.Libros.SingleOrDefault(c => c.ID == id);
			if (libros == null)
				return HttpNotFound();
			return View(libros);
		}

		public ActionResult Edit(int id)
		{
			//var libros = GetLibros().SingleOrDefault(c => c.ID == id);
			var libros = _context.Libros.SingleOrDefault(c => c.ID == id);

			if (libros == null)
				return HttpNotFound();
			var viewModel = new NewLibroViewModel
			{
				Libro = libros,
				TipoLibros = _context.TipoLibros.ToList()
			};
			return View("Nueva", viewModel);
		}

		public ActionResult Eliminar(int id)
		{
			//var libros = GetLibros().SingleOrDefault(c => c.ID == id);
			var libros = _context.Libros.SingleOrDefault(c => c.ID == id);

			if (libros == null)
				return HttpNotFound();
			else
			{
				_context.Libros.Remove(libros);
				_context.SaveChanges();
			}
			return RedirectToAction("Lista", "Libros");
		}


		private IEnumerable<Libro> GetLibros()
		{
			return new List<Libro>
			{
				//new Libro {ID=1, Titulo= "Marketing", Autor="Stephen"},
				//new Libro {ID=2, Titulo= "Emprendimiento", Autor="Carlos Prieto"}
			};
		}

		public ActionResult Nueva()
		{
			var tipoLibros = _context.TipoLibros.ToList();
			var viewModel = new NewLibroViewModel
			{
				TipoLibros = tipoLibros
			};
			return View(viewModel);
		}

		//Metodo para encadenar la base de datos
		[HttpPost]
		public ActionResult Create(Libro libro)
		{
			if (libro.ID == 0)
				_context.Libros.Add(libro);
			else
			{
				var libroEnBd = _context.Libros.Single(c => c.ID == libro.ID);
				libroEnBd.Titulo = libro.Titulo;
				libroEnBd.Autor = libro.Autor;
				libroEnBd.Edicion = libro.Edicion;
				libroEnBd.ISBN = libro.ISBN;

				//TryUpdateModel(clienteEnBd);
			}
			_context.SaveChanges();
			return RedirectToAction("Lista", "Libros");
		}
	}
}