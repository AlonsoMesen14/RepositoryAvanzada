using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Notas
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public DateTime Fecha { get; set; }

        //public Rubros Rubro { get; set; }

        public int CursoId { get; set; }
        public Curso Curso { get; set; }

        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }

        //public int GrupoId { get; set; }
        //public Grupo Grupo { get; set; }

        public ICollection<ApplicationUser> ApplicationUsersId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        
        //public string NombreCarrera { get; set; }
        //public modalidad Modalidad{ get; set; }
        //public string Estado { get; set; }







        //public enum modalidad
        //{
        //    Ordinario = 0,
        //    Suficiencia = 1,
        //    Convalidacion = 2
        //}
    }
}
