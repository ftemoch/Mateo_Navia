using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clase12.Models;
using Clase12.ViewModels;

namespace Clase12.Controllers
{
	public class ClientesController : Controller
	{
		private ApplicationDbContext _context;
		public ClientesController()
		{
			_context = new ApplicationDbContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Cliente
		public ViewResult Lista()
		{
			//var clientes = GetClientes();
			var Clientes = _context.Clientes.ToList();
			return View(Clientes);
		}

		public ActionResult Details(int id)
		{
			//var clientes = GetClientes().SingleOrDefault(c => c.ID == id);
			var clientes = _context.Clientes.SingleOrDefault(c => c.ID == id);
			if (clientes == null)
				return HttpNotFound();
			return View(clientes);
		}

		public ActionResult Edit (int id)
		{
			//var clientes = GetClientes().SingleOrDefault(c => c.ID == id);
			var clientes = _context.Clientes.SingleOrDefault(c => c.ID == id);

			if (clientes == null)
				return HttpNotFound();
			var viewModel = new NewClienteViewModel
			{
				Cliente = clientes,
				TipoClientes = _context.TipoClientes.ToList()
			};
			return View("Nueva", viewModel);
		}

		public ActionResult Eliminar(int id)
		{
			//var clientes = GetClientes().SingleOrDefault(c => c.ID == id);
			var cliente = _context.Clientes.SingleOrDefault(c => c.ID == id);

			if (cliente == null)
				return HttpNotFound();
			else
			{
				_context.Clientes.Remove(cliente);
				_context.SaveChanges();
			}
			return RedirectToAction("Lista", "Clientes");
		}


		private IEnumerable<Cliente> GetClientes()
		{
			return new List<Cliente>
			{
				 //new Cliente {ID=1, Nombre= "Sebastian"},
				 //new Cliente {ID=2, Nombre= "Maximiliano"}
			};
		}

		public ActionResult Nueva()
		{
			var tipoClientes = _context.TipoClientes.ToList();
			var viewModel = new NewClienteViewModel
			{
				TipoClientes = tipoClientes
			};
			return View(viewModel);
		}

	//Metodo para encadenar la base de datos
	[HttpPost]
		public ActionResult Create(Cliente cliente)
		{
			if (cliente.ID == 0)
			_context.Clientes.Add(cliente);
			else
			{
				var clienteEnBd = _context.Clientes.Single(c => c.ID == cliente.ID);
				clienteEnBd.Nombre = cliente.Nombre;
				clienteEnBd.Apellido = cliente.Apellido;
				clienteEnBd.EstaInscritoRevista = cliente.EstaInscritoRevista;
				clienteEnBd.tipoCliente = cliente.tipoCliente;
			//TryUpdateModel(clienteEnBd);
			}
			_context.SaveChanges();
			return RedirectToAction("Lista", "Clientes");
		}

	}
}