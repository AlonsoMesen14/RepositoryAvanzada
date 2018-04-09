using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Carreras
    {
        public int Id { get; set; }        
        public string Nombre_Carrera { get; set; }

        public PersonaPorTipo Persona { get; set; }

        //public ICollection<PersonaPorTipo> Personas { get; set; } = new List<PersonaPorTipo>();
        public ICollection<Carreras_Cursos> Cursos { get; set; } = new List<Carreras_Cursos>();

    }
}
