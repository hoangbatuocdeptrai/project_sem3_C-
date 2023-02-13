using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyWeb.Data;
using MyWeb.Models;
using Newtonsoft.Json;

namespace MyWeb.Controllers
{
    public class CartController : Controller, IActionFilter
    {
        private readonly AppDbContext _context;

        private List<Cart> cart = new List<Cart>();
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Carrt"); // Dữ liệu lưu trong sesion
            if (cartInSession != null)
            {
                cart = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }


        public IActionResult Add(int id)
        {
            if (cart.Any(c => c.Id == id))//nếu có sp này trong ss
            {
                cart.Where(c => c.Id == id).First().Quantity += 1;
            }
            else
            {
                //nếu chưa có
                var pro = _context.Products.Find(id);
                var Item = new Cart() { Id = pro.ProductID, Name = pro.ProductName, Image = pro.Image, Price =(float) pro.Price, Quantity = 1 };
                cart.Add(Item);
            }
            HttpContext.Session.SetString("My-Carrt", JsonConvert.SerializeObject(cart));

            return RedirectToAction("Index", "Cart");
        }
        public IActionResult Remove(int id)
        {
            if (cart.Any(c => c.Id == id)) // nếu có sản phẩm này trong Session giỏ hàng
            {
                var item = cart.Where(c => c.Id == id).First(); // tìm sản phẩm đó trong session giỏ hàng
                cart.Remove(item); // Xóa đối trượng Cart tìm được khỏi List<Cart>

                HttpContext.Session.SetString("My-Carrt", JsonConvert.SerializeObject(cart));
            }
            return RedirectToAction("Index", "Cart");
        } 

        public IActionResult Update(int id, int quantity)
        {
            if (cart.Any(c => c.Id == id)) // nếu có sản phẩm này tron Session giỏ hàng
            {
                cart.Where(c => c.Id == id).First().Quantity = quantity;
                HttpContext.Session.SetString("My-Carrt", JsonConvert.SerializeObject(cart));
            }
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Clear()
        {
            
            HttpContext.Session.Remove("My-Carrt");
            return RedirectToAction("Index", "Cart");
        }


        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(cart);
        }
    }
}