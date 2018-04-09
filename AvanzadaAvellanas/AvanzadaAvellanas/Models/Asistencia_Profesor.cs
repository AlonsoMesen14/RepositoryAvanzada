using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Asistencia_Profesor
    {
        public int Id { get; set; }
        public int Profesor { get; set; }

        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Salida { get; set; }

        //public PersonaPorTipo PersonaPorTipo { get; set; }


    }
}
