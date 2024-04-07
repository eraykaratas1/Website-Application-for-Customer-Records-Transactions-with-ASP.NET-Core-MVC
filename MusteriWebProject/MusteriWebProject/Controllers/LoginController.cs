using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusteriWebProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MusteriWebProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginPage(Admin model)
        {
            var admin = c.Admins_Information
                            .FirstOrDefault(a => a.AdminAd == model.AdminAd && a.Sifre == model.Sifre);

            if (admin != null)
            {
                return RedirectToAction("HomePage", "Home"); 
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Geçersiz kullanıcı adı veya şifre");
                return View(model);
            }
        }

    }
}
