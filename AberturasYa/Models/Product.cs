using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AberturasYa.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(150)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [StringLength(500)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        public double? Stock { get; set; }
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Precio")]
        public double Price { get; set; }
        [Display(Name = "Descuento")]
        public double? Discount { get; set; }
        [Display(Name = "Activar/Desactivar")]
        public bool IsActive { get; set; }
        [Display(Name = "Visible en Web")]
        public bool IsWebActive { get; set; }
        [Display(Name = "Producto de Oferta")]
        public bool IsSale { get; set; }
        [Display(Name = "Código interno")]
        public int Code { get; set; }
        [Display(Name = "Código de barras")]
        public int? BarCode { get; set; }

        public SubCategory SubCategory { get; set; }
        public int? SubCategoryId { get; set; }

        public ICollection<Image> Images { get; set; }


    }
}