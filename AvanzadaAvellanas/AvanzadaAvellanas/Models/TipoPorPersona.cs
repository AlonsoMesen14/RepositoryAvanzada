using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class TipoPorPersona
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int TipoPersonaId { get; set; }
        public TipoPersona TipoPersona { get; set; }

    }
}
