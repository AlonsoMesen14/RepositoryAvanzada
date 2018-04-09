using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class PersonaPorTipo
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int TipoPersonaId { get; set; }
        public TipoPersona TipoPersona { get; set; }

        public int CarreraId { get; set; }
        public Carreras Carreras{ get; set; }


        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

    }
}
