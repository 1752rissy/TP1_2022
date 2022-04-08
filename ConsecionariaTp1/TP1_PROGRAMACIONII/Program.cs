using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Clases;

namespace TP1_PROGRAMACIONII
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Consecionaria consecionaria1 = new Consecionaria();
            consecionaria1.NombreConsecionaria = "SAPAG";
           


            Vehiculo vehiculo1 = new Vehiculo();
            vehiculo1.Marca = "FIAT";
            vehiculo1.Modelo = "Argo";
            vehiculo1.Patente = "AD 154 FT";
            vehiculo1.Precio = 4000000;

           
            Cliente cliente1 = new Cliente();
            
            cliente1.Nombre = "Ramon";
            cliente1.Apellido = "Don";
            cliente1.DNI = 30134840;
            


            FCA fca1 = new FCA();
            fca1.EntidadFinanciera = "FinancieraYA";

            consecionaria1.AgregarCliente(cliente1);
            cliente1.AveriguarFinanciacion(vehiculo1);
            cliente1.AgregarVehiculo(vehiculo1);
            fca1.FinanciarVehiculo(vehiculo1);
            consecionaria1.InformarFinanciacion(vehiculo1);
            

            Console.ReadLine();
                
        }
    }
}
