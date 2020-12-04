using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class City
    {
        public int CityId { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Ciudad")]
        public string Name { get; set; }

        public State State { get; set; }
        public int StateId { get; set; }

    }
}