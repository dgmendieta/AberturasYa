using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Nombre fantasía")]
        public string Name { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Razón Social")]
        public string LegalName { get; set; }
        [Display(Name = "R.U.T.")]
        public int CompanyNumber { get; set; }
        public Customer Customer { get; set; }
        public int? CustomerId { get; set; }



    }
}