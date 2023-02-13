using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MembersController : Controller
    {
        private readonly AppDbContext _context;

        public MembersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users users)
        {
            var check = _context.Users.FirstOrDefault(X => X.Name == users.Name && X.Password == users.Password);
            if (check != null)
            {
                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, users.Name) }, "Bkap2022");
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync("Bkap2022", principal);
                return Redirect("~/Admin/Dashboard/Index");
            }
            ViewBag.error = "Wrong username or password !!";
            return View();
        }

        public IActionResult Logout()
        {
            var logout = HttpContext.SignOutAsync("Bkap2002");
            return RedirectToAction("Login");
        }

    }
}