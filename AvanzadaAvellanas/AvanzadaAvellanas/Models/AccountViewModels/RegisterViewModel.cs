using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvanzadaAvellanas.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public int Cedula { get; set; }

        [Required]        
        public int Carne { get; set; }

        [Required]
        public int Sexo { get; set; }

        [Required]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime Fecha_Nacimiento{ get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Required]
         public ICollection<TipoPersona> Tipo { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}
