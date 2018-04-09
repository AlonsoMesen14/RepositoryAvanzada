using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class TipoPersona_Carreras
    {
       
        public int CarreraId { get; set; }
        public Carreras Carreras { get; set; }

        public int PersonaPorTipoId { get; set; }
        public PersonaPorTipo PersonaPorTipo { get; set; }

    }
}
