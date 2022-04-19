using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PROGRAMACIONII
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string AveriguarFinanciacion(Vehiculo vehiculo)
        {
            return $"Quisiera saber que financiacion existe para el vehiculo {vehiculo.Marca} con patente {vehiculo.Patente}";
        }
    }
}
