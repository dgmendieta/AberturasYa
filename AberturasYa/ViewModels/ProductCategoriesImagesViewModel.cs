using AberturasYa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AberturasYa.ViewModels
{
    public class ProductCategoriesImagesViewModel
    {
        public List<Product> Products { get; set; }
        public List<Image> Images { get; set; }
        public List<Category> Categories { get; set; }

    }
}