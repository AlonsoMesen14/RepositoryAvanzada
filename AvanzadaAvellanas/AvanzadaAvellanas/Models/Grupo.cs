using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        public int Horario { get; set; } //enum o pasar por debajo 

        //foreignkey Curso
        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        
        public ICollection<PersonaPorTipo> Persona { get; set; } = new List<PersonaPorTipo>();

        //public ICollection<Rubros> Rubros { get; set; }
    }
}
