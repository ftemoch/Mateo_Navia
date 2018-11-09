using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Clase12.Models;

namespace Clase12.ViewModels
{
	public class NewTarifaViewModel
	{
		public IEnumerable<Tarifas> Tarifas { get; set; }
		public Tarifas Tarifa { get; set; }
	}
}