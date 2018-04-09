using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Asistencia_Estudiante
    {
        public int Id { get; set; }
        public DateTime FechaAsistencia { get; set; }
        public int Asistencia { get; set; } //ausent, asiste,tarde
        public string Comentarios { get; set; }

        public int ProfesorId { get; set; }
        public int EstudianteId { get; set; }

        //foreign key Curso
        public int CursoId { get; set; } //string 
        public Curso Curso { get; set; }

        //foreign key Grupo
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }




    }
}
