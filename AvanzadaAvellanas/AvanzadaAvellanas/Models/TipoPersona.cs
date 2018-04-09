using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models
{
    public class TipoPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }


        //public string ApplicationUserId { get; set; }
        public ICollection<PersonaPorTipo> ApplicationUsers { get; set; } = new List<PersonaPorTipo>();
       
    //public ICollection<TipoPersona_Carreras> Carreras { get; set; } = new List<TipoPersona_Carreras>();
}
}
