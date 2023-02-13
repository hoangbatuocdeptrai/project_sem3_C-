using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class CheckOutController : Controller
    {
        private readonly AppDbContext _context;
        public CheckOutController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // POST khi submit form
        public IActionResult Index(string userName, string password)
        {
            bool check = true;
            if(string.IsNullOrEmpty(userName))         
            {
                TempData["userName"] = "User Name cannot be empty";
                    check = false;
            }
            if (string.IsNullOrEmpty(password))
            {
                TempData["password"] = "Password cannot be empty";
                check = false;
            }
         
            if(check == true)
            {

            
                // sẽ xử lý logic phần đăng nhập tại đây
                var checkAcc = _context.Customers.FirstOrDefault(c => c.UserName == userName && c.Password == password);
                if (checkAcc != null)
                {
                    HttpContext.Session.SetString("LoginCustomer", userName);
                    HttpContext.Session.SetInt32("LoginCustomers", checkAcc.CustomerID);
                    HttpContext.Session.SetString("CustomerName", checkAcc.CustomerName);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["err"] = "Incorrect account or password.";
                    return View();
                }

            }
                
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("LoginCustomer");
            return RedirectToAction("Index", "Home");
        }
    }
}
