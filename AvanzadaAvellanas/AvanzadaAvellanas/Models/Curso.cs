using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Curso
    {
        public string Id { get; set; }
        public string Nombre_Curso { get; set; }
        public int Precio { get; set; }
        public int Estado { get; set; } //aprobado, reprobado, cursando 
        public int Creditos { get; set; }

        public ICollection<Curso> Curso_Rquerido { get; set; } = new List<Curso>();


        //public ICollection<TipoPersona> Persona { get; set; } = new List<TipoPersona>();

        public ICollection<Carreras_Cursos> Carreras { get; set; } = new List<Carreras_Cursos>();

        public ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();


        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
    }




}
