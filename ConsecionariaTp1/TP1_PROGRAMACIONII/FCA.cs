using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PROGRAMACIONII
{
    public class FCA
    {
        public string EntidadFinanciera { get; set; }
        public List<Vehiculo> ListadoDeVehiculos = new List<Vehiculo>();

        public FCA()
        {
            ListadoDeVehiculos = new List<Vehiculo>();
        }
        public double FinanciarVehiculo(Vehiculo vehiculo)
        {
            ListadoDeVehiculos.Add(vehiculo);
            return  vehiculo.Precio + (vehiculo.Precio * 0.55);
        }
    }
}
