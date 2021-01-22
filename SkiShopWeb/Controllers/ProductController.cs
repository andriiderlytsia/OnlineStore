using Microsoft.AspNetCore.Mvc;
using SkiShopWeb.Data.Interfaces;
using SkiShopWeb.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly SkiShopContext Db;
        private readonly ICategory _categories;
        private readonly IProduct _products;
        

        public ProductController(SkiShopContext skiShopContext, ICategory category,IProduct product)
        {
            Db = skiShopContext;
            _categories = category;
            _products = product;
           
        }
        //[HttpPost]
        //public string PostComment()
        //{
        //    string str = Request.Form["Comment"];
        //    return "this is  " + str;
        //    //string comment = Request.Form["Comment"];
           
        //}
    

        public IActionResult MoreInfo(int id)
        {
            var product = _products.GetProductById(id);
            return View(product);
        }
        public IActionResult SignUp(int id)
        {
            ViewBag.ProdID = id;
            
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Customer customer)
        {
            
            if (ModelState.IsValid)
            {
                Db.Customers.Add(customer);
                Db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var categories = _categories.GetCategories.ToList() ;
            return View(categories);
        }
        public IActionResult AllProducts()
        {

            var products = _products.GetProducts;
            return View(products);
        }
        public IActionResult AllCategories()
        {
            //SkiShopContext db = new SkiShopContext();
            //CategoryRepository categoryRepository = new CategoryRepository(Db);

            var categories = _categories.GetCategories;
            return View(categories);
        }
        public IActionResult Snowboards()
        {
            var products = Db.Products.Where(x => x.Category.CategoryName == "Snowboard").ToList();
            return View(products);
        }
        public IActionResult Skis()
        {
            var products = Db.Products.Where(x => x.Category.CategoryName == "Skis").ToList();
            return View(products);
        }
        public IActionResult SkiBoots()
        {
            var products = Db.Products.Where(x => x.Category.CategoryName == "Ski Boots").ToList();
            return View(products);

        }
        public IActionResult Poles()
        {
            var products = Db.Products.Where(x => x.Category.CategoryName == "Poles").ToList();
            return View(products);
        }
      
    }
}
