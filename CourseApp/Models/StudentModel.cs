using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class StudentModel
    {
        [Required (ErrorMessage ="İsminizi giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Eposta adresnizi giriniz.")]
        [EmailAddress(ErrorMessage = "Eposta adresinizi doğru giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon numaranızı giriniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılma durumunuzu seçiniz.")]
         public bool? Confirm { get; set; }
    }
}
