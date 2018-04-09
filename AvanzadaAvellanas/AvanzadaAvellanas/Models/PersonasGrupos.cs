using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class PersonasGrupos
    {
        public int Id { get; set; }

        public string PersonaPorTipoId { get; set; }
        public PersonaPorTipo PersonaPorTipo { get; set; }

        public string CursoId { get; set; }
        public Curso Curso { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
    }
}
