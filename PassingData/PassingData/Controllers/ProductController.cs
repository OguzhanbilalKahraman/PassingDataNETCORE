using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string name= "oguz han";
            return View(name as Object);

        }


        public IActionResult UrunGoster()
        {
            Product product = new Product();
            product.ProductName = "Leptop";
            product.UnitPrices = 15000;
            return View(product);
        }

        public IActionResult GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ProductName="Telefon",CategoryName="elektronik",UnitPrices=5587},
                new Product(){ProductName="Bilgisayar",CategoryName="elektronik",UnitPrices=15587},
                new Product(){ProductName="Buzdolabı",CategoryName="beyaz eşya",UnitPrices=19587},
                new Product(){ProductName="Koltuk",CategoryName="ev eşyası",UnitPrices=5587}
            };


            return View(products);
        }
    }
}
