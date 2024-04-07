
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MusteriWebProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriWebProject.Controllers
{

    public class HomeController : Controller
    {
        Context c = new Context();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult HomePage()
        {

            var values = c.Customers_Information.ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddRecord()
        {
            List<SelectListItem> degerler = (from x in c.Customers_Information.Distinct().ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Kampanya,
                                                 Value = x.Kampanya.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();

        }
        [HttpPost]
        public IActionResult AddRecord(CustomerC a)
        {

            c.Customers_Information.Add(a);
            c.SaveChanges();

            return RedirectToAction("HomePage");
        }
        public IActionResult DeleteRecord(int id)
        {

            var dep = c.Customers_Information.Find(id); 
            c.Customers_Information.Remove(dep);
            c.SaveChanges();

            return RedirectToAction("HomePage");
        }
        public IActionResult UpdateRecord(int id)
        {

            var dep = c.Customers_Information.Find(id);

            return View("UpdateRecord", dep);
        }
        [HttpPost]
        public IActionResult UpdateRecord(CustomerC cl)
        {

            var dep = c.Customers_Information.Find(cl.CustKey);

            dep.MusteriNo = cl.MusteriNo;
            dep.Adı = cl.Adı;
            dep.Soyadı = cl.Soyadı;
            dep.Kampanya = cl.Kampanya;
            dep.Kaynak = cl.Kaynak;
            dep.KayitTarihiBaslangici = cl.KayitTarihiBaslangici;
            dep.KayitTarihiBitisi = cl.KayitTarihiBitisi;
            dep.GorusmeSonucu = cl.GorusmeSonucu;
            dep.TelefonNo = cl.TelefonNo;
            dep.AramaTarihi = cl.AramaTarihi;
            dep.Temsilci = cl.Temsilci;
            c.SaveChanges();

            return RedirectToAction("HomePage");
        }
        [HttpGet]
        public IActionResult SearchRecord()
        {

            List<SelectListItem> degerler = (from x in c.Customers_Information.ToList()
                                             select new SelectListItem
                                             {

                                                 Text = x.Kampanya,
                                                 Value = x.Kampanya.ToString()
                                                 // .Distinct()

                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();


        }
        public IActionResult ListSearchRecord(CustomerC searchdata)
        {
            var arama_degerler = c.Customers_Information.Where(x => x.MusteriNo == searchdata.MusteriNo || x.Adı == searchdata.Adı || x.Soyadı == searchdata.Soyadı || x.Kampanya == searchdata.Kampanya || x.Kaynak == searchdata.Kaynak || x.KayitTarihiBaslangici == searchdata.KayitTarihiBaslangici || x.KayitTarihiBitisi == searchdata.KayitTarihiBitisi).ToList();

            return View("ListSearchRecord", arama_degerler);

        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
