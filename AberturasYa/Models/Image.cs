using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        [Required]
        [Display(Name = "Ruta de la imagen")]
        public string Url { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Título de la imagen")]
        public string Name { get; set; }

        public Product Product { get; set; }
        public int? ProductId { get; set; }
        public Customer Customer { get; set; }
        public int? CustomerId { get; set; }
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
    }
}