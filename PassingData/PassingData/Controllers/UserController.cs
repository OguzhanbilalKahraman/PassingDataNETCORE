using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
            {
                new User(){FirstName="Safa",LastName="Başdemir"},
                new User(){FirstName="Esma",LastName="Taşdemir"},
                new User(){FirstName="Güven",LastName="Şef"},
                new User(){FirstName="Tülay",LastName="Zengin"}

            };
        
        public IActionResult UseViewBag()
        {

            ViewBag.Username = "Oguzhan";
            User user = new User();
            user.FirstName = "emre";
            user.LastName = "katip";
            ViewBag.User = user;


            //List<User> users = new List<User>()
            //{
            //    new User(){FirstName="Safa",LastName="Başdemir"},
            //    new User(){FirstName="Esma",LastName="Taşdemir"},
            //    new User(){FirstName="Güven",LastName="Şef"},
            //    new User(){FirstName="Tülay",LastName="Zengin"}

            //}; 
            ViewBag.Users = users;

            return View();
        }

        public IActionResult UseViewData()
        {

            ViewData["Username"] = "Abdullah";
            User user = new User();

            user.FirstName = "Erol";
            user.LastName = "Taş";
            ViewData["User"] = user;

            ViewData["Users"] = users;



            return View();

        }

        public IActionResult UseTempData()
        {

            TempData["name"] = "Hanife";
            return RedirectToAction("TempDataTest");
        }

        public IActionResult TempDataTest()
        {
            TempData.Keep("name");
            //string userName = TempData["name"].ToString();
            return View();
        }
    }
}
