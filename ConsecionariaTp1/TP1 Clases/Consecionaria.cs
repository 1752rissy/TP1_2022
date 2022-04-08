using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Clases
{
    public class Consecionaria

    {
        public string NombreConsecionaria { get; set; } 
        public List<Vehiculo> vehiculoList { get; set; }
        public List<Cliente> clienteList { get; set; }



        public Consecionaria()

        {
            vehiculoList = new List<Vehiculo>();
        }

        public void AgregarCliente (Cliente cliente)
        {

            clienteList.Add(cliente);
        }

        public double InformarFinanciacion(Vehiculo vehiculo)
        {
            return  vehiculo.Precio*0.55;

        }



    }
}
