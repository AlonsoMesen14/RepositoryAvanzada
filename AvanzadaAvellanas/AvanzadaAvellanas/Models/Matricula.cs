using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class Matricula
    {

        public int Id { get; set; }
        public int CreditosMaximos { get; }
        public int CreditosMatriculados { get; set; }
        public int MontoTotal { get; set; }
        public int Online { get; set; }

        public int PersonaPorTipoId { get; set; }
        public PersonaPorTipo PersonaPorTipo{ get; set; }

        public int CarreraId { get; set; }
        public Carreras Carrera { get; set; }

        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

        public Grupo Grupo { get; set; }
    }
}
