using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Clases
{
    public class FCA
    {
        public string EntidadFinanciera { get; set; }
        public List<Vehiculo> vehiculoList = new List<Vehiculo>();

        public FCA()

        {
            vehiculoList = new List<Vehiculo>();
        }

        public double FinanciarVehiculo(Vehiculo vehiculo)
        {
            vehiculoList.Add(vehiculo);
            return (vehiculo.Precio*0.55)+vehiculo.Precio;
        }


    } 
}
