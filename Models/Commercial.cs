using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System;

namespace GsbApp.Models
{
    public class Commercial
    {
        public int ID { get; set; }
        [Display(Name = "Prenom")]
        public string FirstName { get; set; }
        [Display(Name = "Nom")]
        public string LastName { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Adresse")]
        public string adress { get; set; }
        [Display(Name = "Ville")]
        public string City { get; set; }
        [Display(Name = "Code Postal")]
        public int CodePostal { get; set; }
        [DataType(DataType.Date), Display(Name = "Date d'embauche")]
        public DateTime HiringDate { get; set; }
        public string Password { get; set; }
    }
}