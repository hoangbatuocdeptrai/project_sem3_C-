using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;

namespace MyWeb.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        int category = 0;
        public IActionResult Index(int id)
        {
            ViewBag.cate = _context.Categories.ToList();
            category = id;
            if (id > 0)
            {

                ViewBag.pro = _context.Products.OrderBy(c => c.ProductID).Include(p => p.Category).Where(x => x.CategoryID == id);

            }
            else
            {
                ViewBag.pro = _context.Products.OrderBy(c => c.ProductID).Include(p => p.Category);

            }

            return View();
        }
    }
}