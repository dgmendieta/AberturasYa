using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Calle")]
        public string Street { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Número de puerta")]
        public string Number { get; set; }
        [Display(Name = "Apartamento")]
        public string ApartmentNumber { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Esquina")]
        public string Corner1 { get; set; }
        [Display(Name = "Entre Calles")]
        public string Corner2 { get; set; }
        [Display(Name = "Comentarios")]
        public string Comments { get; set; }
        [Display(Name = "Barrio")]
        public string Neighborhood { get; set; }
        [Display(Name = "Código Postal")]
        public int? Zip { get; set; }
        public Customer Customer { get; set; }
        public int? CustomerId { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }
        public State State { get; set; }
        public int? StateId { get; set; }

    }
}