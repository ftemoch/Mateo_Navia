using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clase12.Models;

namespace Clase12.ViewModels
{
	public class NewClienteViewModel
	{
		public IEnumerable<TipoCliente> TipoClientes { get; set; }
		public Cliente Cliente { get; set; }
	}
}