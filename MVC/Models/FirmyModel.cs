using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class FirmyModel
    {
        public int IdFirmy { get; set; }
        public int IdSiedzibyFirmy { get; set; }

        [Required(ErrorMessage= "Wymagane pole")]
        public string NazwaFirmy { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Nip { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Regon { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Miasto { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Ulica { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string NrBudynku { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string NrLokalu { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string KodPocztowy { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Poczta { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string NrTelefonu { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Kraj { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string StronaWWW { get; set; }
        [Required(ErrorMessage = "Wymagane pole")]
        public string NrKonta { get; set; }
    }
}