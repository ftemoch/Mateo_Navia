using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase12.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public double Salario { get; set; }
        public bool Activo { get; set; }
    }
}