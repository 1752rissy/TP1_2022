using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PROGRAMACIONII
{
    public class Consecionaria
    {
        public string NombreConsecionaria { get; set; }
        public List<Vehiculo> VehiculoList { get; set; }
        public List<Cliente> ClienteList { get; set; }
        public FCA EntindadFinanciera { get; set; }

        public Consecionaria()
        {
            VehiculoList = new List<Vehiculo>();
            ClienteList = new List<Cliente>();
            EntindadFinanciera = new FCA();
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            VehiculoList.Add(vehiculo);
        }
        public void AgregarCliente(Cliente cliente)
        {
            ClienteList.Add(cliente);
        }
        public void AsignarFinanciera(string NombreEntidadFinanciera)
        {
            EntindadFinanciera.EntidadFinanciera = NombreEntidadFinanciera;
        }

        public string InformarFinanciacion(Vehiculo vehiculo)
        {
            return $"La informacion de financiacion para el vehiculo consultado es la siguiente: \nVehiculo: {vehiculo.Marca} | {vehiculo.Modelo} | {vehiculo.Patente} \nPrecio: $ {String.Format("{0:0,0.0}", vehiculo.Precio + vehiculo.Precio * 0.55)}\nFinanciera: {EntindadFinanciera.EntidadFinanciera}";
        }
    }
}
