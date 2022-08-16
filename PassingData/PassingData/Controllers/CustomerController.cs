using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {

        List<Customer> customers = new List<Customer>(){
            
            new Customer(){FirstName="Oguz",LastName="kahraman"},
            new Customer(){FirstName="Esra",LastName="Öz"},
            new Customer(){FirstName="Onur",LastName="Durak"},
            new Customer(){FirstName="Hanife",LastName="Alkan"}
            
            };

        public object CustomerAndProduct { get; private set; }

        public IActionResult UseViewModel()
        {
            Product product = new Product();
            product.ProductName = "Monitör";
            product.CategoryName = "Elektronik";
            product.UnitPrices = 1;

            string date = DateTime.Now.ToString();


            CustomerAndProductVM customerAndProduct = new CustomerAndProductVM();
            customerAndProduct.customers = customers;
            customerAndProduct.product = product;
            customerAndProduct.date = date;





            return View(customerAndProduct);
        }


        public IActionResult UseTuple()
        {
            Product product = new Product();
            product.ProductName = "Telefon";
            product.CategoryName = "Elektronik";
            product.UnitPrices = 6;

            string date = DateTime.Now.ToString();
            (List<Customer>,Product,string) CustomerAndProduct =(customers,product,date);


            return View(CustomerAndProduct);
        }
    }
}
