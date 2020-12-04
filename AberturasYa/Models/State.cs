using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class State
    {
        public int StateId { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Departamento")]
        public string Name { get; set; }

    }
}