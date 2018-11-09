using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;
using Clase12.ViewModels;

namespace Clase12.Controllers
{
    public class TarifaController : Controller
    {
		private ApplicationDbContext _context;
		public TarifaController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Tarifa
		public ViewResult ListaTarifas()
		{
			//var tarifas = GetTarifas();
			var tarifas = _context.Tarifas.ToList();
			return View(tarifas);
		}

		public ActionResult Details(int id)
		{
			//var tarifas = GetTarifas().SingleOrDefault(c => c.Id == id);
			var tarifas = _context.Tarifas.SingleOrDefault(c => c.Id == id);
			if (tarifas == null)
				return HttpNotFound();
			return View(tarifas);
		}

		public ActionResult Edit(int id)
		{
			var tarifas = _context.Tarifas.SingleOrDefault(c => c.Id == id);

			if (tarifas == null)
				return HttpNotFound();
			var viewModel = new NewTarifaViewModel
			{
				Tarifa = tarifas,
				Tarifas = _context.Tarifas.ToList()
			};
			return View("NuevaTarifa", viewModel);
		}

		public ActionResult Eliminar(int id)
		{

			var tarifas = _context.Tarifas.SingleOrDefault(c => c.Id == id);

			if (tarifas == null)
				return HttpNotFound();
			else
			{
				_context.Tarifas.Remove(tarifas);
				_context.SaveChanges();
			}
			return RedirectToAction("ListaTarifas", "Tarifa");
		}

		private IEnumerable<Tarifas> GetTarifas()
		{
			return new List<Tarifas>
			{
				//new Tarifas {Id=1, Nombre= "Ejecutiva"},
				//new Tarifas {Id=2, Nombre= "Economica"}
			};
		}

		public ActionResult NuevaTarifa()
		{
			var tarifas = _context.Tarifas.ToList();
			var viewModel = new NewTarifaViewModel
			{
				Tarifas = tarifas
			};
			return View(viewModel);
		}

		//Metodo para encadenar la base de datos
		[HttpPost]
		public ActionResult Create(Tarifas tarifa)
		{
			if (tarifa.Id == 0)
				_context.Tarifas.Add(tarifa);
			else
			{
				var tarifaEnBd = _context.Tarifas.Single(c => c.Id == tarifa.Id);
				tarifaEnBd.Nombre = tarifa.Nombre;
				tarifaEnBd.Costo = tarifa.Costo;
				tarifaEnBd.Descuento = tarifa.Descuento;
				tarifaEnBd.Fecha = tarifa.Fecha;
			}
			_context.SaveChanges();
			return RedirectToAction("ListaTarifas", "Tarifa");
		}


	}
}