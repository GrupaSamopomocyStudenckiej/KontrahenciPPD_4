using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class PracownicyModel
    {
        public int IdPracownika { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public int IdFirmy { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string NrTelefonu { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Email { get; set; }
    }
}