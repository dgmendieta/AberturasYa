using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Nombre")]
        public string  FirstName { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Email/Usuario")]
        public string Email { get; set; }
        [StringLength(20)]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "Celular")]
        public string Cellphone { get; set; }
        public ICollection<Image> Images { get; set; }

    }
}