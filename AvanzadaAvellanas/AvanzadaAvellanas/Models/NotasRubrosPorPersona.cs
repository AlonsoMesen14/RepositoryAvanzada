using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class NotasRubrosPorPersona
    {
        public int Id { get; set; }

        public TipoPersona Persona { get; set; }
        public Curso Curso { get; set; }
        public Rubros Rubros { get; set; }
        public Notas Notas { get; set; }

    }
}
