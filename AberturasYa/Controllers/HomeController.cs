using AberturasYa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using AberturasYa.ViewModels;

namespace AberturasYa.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //GET: Product
        public ActionResult Index()
        {
            List<Product> products = db.Products.Where(p => p.IsSale == true).ToList();
            List<Image> images = new List<Image>();
            List<Category> categories = db.Categories.ToList();
                    foreach (var p in products)
                    {
                     images.AddRange(db.Images.Where(i => i.ProductId == p.ProductId).ToList());
                    }
                    foreach (var c in categories)
                    {
                    images.AddRange(db.Images.Where(i => i.CategoryId == c.CategoryId).ToList());
                    }


            var viewModel = new ProductCategoriesImagesViewModel {
                Products = products,
                Images = images,
                Categories = categories
                };

        
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}