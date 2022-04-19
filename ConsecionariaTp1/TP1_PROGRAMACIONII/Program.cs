using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PROGRAMACIONII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nuevas instancias de clases
            Consecionaria consecionariaChina = new Consecionaria();
            Cliente clienteNuevo = new Cliente();
            Vehiculo miAuto = new Vehiculo();
            FCA financiera = new FCA();

            // Asignacion de valores iniciales
            consecionariaChina.NombreConsecionaria = "Sahuan Yen Chen";
            miAuto.Marca = "Chevy";
            miAuto.Modelo = "Huaian";
            miAuto.Patente = "AF 278 RE";
            miAuto.Precio = 12000000;
            clienteNuevo.Nombre = "Javier Luis";
            clienteNuevo.Apellido = "Lodeira";
            clienteNuevo.DNI = 27365213;
            financiera.EntidadFinanciera = "YoFinancioTotal";

            consecionariaChina.AsignarFinanciera(financiera.EntidadFinanciera);
            consecionariaChina.AgregarVehiculo(miAuto);
            consecionariaChina.AgregarCliente(clienteNuevo);

            Console.WriteLine(clienteNuevo.AveriguarFinanciacion(miAuto));
            financiera.FinanciarVehiculo(miAuto);

            Console.WriteLine(consecionariaChina.InformarFinanciacion(miAuto));
            Console.ReadLine();
        }
    }
}
