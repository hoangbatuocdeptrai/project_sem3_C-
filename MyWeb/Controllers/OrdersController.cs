using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Data;
using MyWeb.Models;
using Newtonsoft.Json;

namespace MyWeb.Controllers
{
    public class OrdersController : Controller
    {
        private AppDbContext _context;

        public OrdersController(AppDbContext context) => this._context = context;

        private List<Cart> carts = new List<Cart>();

        public IActionResult Index()
        {
            var cartInSession = HttpContext.Session.GetString("My-Carrt");
            if (cartInSession != null)
            {
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            ViewBag.Cart = carts;

            int id = (int)HttpContext.Session.GetInt32("LoginCustomers");
            Customer acc = _context.Customers.FirstOrDefault(a => a.CustomerID == id);
            if (acc.Address == null || acc.Address.Length == 0)
                @ViewBag.Address = "";
            else
                @ViewBag.Address = acc.Address;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Orders order)
        {
            Boolean check = true;


            if (string.IsNullOrEmpty(order.Address))
            {
                TempData["Address"] = "This field is required";
                check = false;
            }



            if (check)
            {
                var cartInSession = HttpContext.Session.GetString("My-Carrt");
                if (cartInSession != null)
                {
                    carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
                }

                order.Status = 1;
                _context.Orders.Add(order);
                _context.SaveChanges();

                int orderId = order.OrderId;
                foreach (var item in carts)
                {
                    var detail = new OrdersDetails() { OrderId = orderId,ProductId = item.Id ,Quantity = item.Quantity, Price = item.Price };
                    _context.OrderDetails.Add(detail);
                    _context.SaveChanges();
                }



                HttpContext.Session.Remove("My-Carrt");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}