using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PROGRAMACIONII
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Patente { get; set; }
        public double Precio { get; set; }
        public FCA EntidadDeCredito { get; set; }
    }
}
