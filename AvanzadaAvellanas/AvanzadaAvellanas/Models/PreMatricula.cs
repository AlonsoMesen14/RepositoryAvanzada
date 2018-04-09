using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class PreMatricula
    {
        public string IDUsuarioMatriculando { get; set; }
        public string IDUsuarioMatriculante { get; set; }
        public string Cursos { get; set; }
        public List<Grupo> Grupos { get; set; }
    }
}
