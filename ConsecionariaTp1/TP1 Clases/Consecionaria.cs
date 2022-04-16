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
        public FCA fca { get; set; }



        public Consecionaria()

        {
            vehiculoList = new List<Vehiculo>();
            clienteList = new List<Cliente>();
            fca = new FCA();
        }


        public void AgregarVehiculo(Vehiculo vehiculo)
        {

            vehiculoList.Add(vehiculo);
        }

        public void AgregarCliente (Cliente cliente)
        {

            clienteList.Add(cliente);
        }

        public void AsignarFCA(string nombreFCA)
        {

            fca.EntidadFinanciera = nombreFCA;
        }


        public double InformarFinanciacion(Vehiculo vehiculo)
        {
            return  (vehiculo.Precio*0.55) + vehiculo.Precio;

        }



    }
}
