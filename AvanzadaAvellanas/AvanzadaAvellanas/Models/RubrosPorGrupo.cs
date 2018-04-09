using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class RubrosPorGrupo
    {
        public int Id { get; set; }

        public int RubroId { get; set; }
        public Rubros Rubros { get; set; }

        public int CarreraId { get; set; }
        public Carreras Carrera { get; set; }

        public int CursoId{ get; set; }
        public Curso Curso{ get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

    }
}
