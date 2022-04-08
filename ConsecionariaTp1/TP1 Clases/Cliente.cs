﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Clases
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<Vehiculo> vehiculoList { get; set; }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {

            vehiculoList.Add(vehiculo);
        }


        public string AveriguarFinanciacion(Vehiculo vehiculo)
        {

            return $"Se envio la consulta por {vehiculo.Modelo}";
        }
    }
}
