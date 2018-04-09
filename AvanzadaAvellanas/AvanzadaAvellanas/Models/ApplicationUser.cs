using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AvanzadaAvellanas.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public int Carne { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Sexo { get; set; }

        //public Matricula Matricula { get; set; }

        public ICollection<PersonaPorTipo> TipoPersonas { get; set; } = new List<PersonaPorTipo>();

        //public ICollection<Curso> Cursos { get; set; } = new List<Curso>();



    }
}
