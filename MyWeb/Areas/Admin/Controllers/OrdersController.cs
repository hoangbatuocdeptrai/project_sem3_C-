using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var order = await _context.Orders.Include(x=>x.Customer).ToListAsync();

            return View(order);
        }

        private object ArrayList()
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> OrdersDetails(int? id)
        {
            var order = await _context.OrderDetails.Include(x => x.Product).Include(x=>x.Orders).Where(x=>x.OrderId == id).ToListAsync();
            return View(order);
        }
       
        public async Task<IActionResult> Edit(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Edit( int OrderId, byte status)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(x=> x.OrderId == OrderId);
            order.Status = status;
            _context.Update(order);
            await _context.SaveChangesAsync();
            return Redirect("Index");
        }

    }
}