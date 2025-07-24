using HanStore.MvsWebUI.Entity;
using HanStore.MvsWebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace HanStore.MvsWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();


        // GET: Home
        public ActionResult Index()
        { 
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 30) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image == null ? "def.jpg" : i.Image,
                    CategoryId = i.CategoryId
                })
                .ToList();


            return View(urunler);
        }

        public ActionResult Details(int Id)
        {
            return View(_context.Products.Where(i => i.Id == Id).FirstOrDefault());
        }

        // GET: List
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                   .Where(i => i.IsApproved)
                   .Select(i => new ProductModel()
                   {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image==null ? "def.jpg" : i.Image,
                    CategoryId = i.CategoryId,
                   })
                    .AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }
        
        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());

        }

        public PartialViewResult GetAdvert()
        {
            var urunler = _context.Products
                .Where(i => i.IsAd && i.IsApproved)
                .Select(i => new ProductModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image == null ? "def.jpg" : i.Image,
                    CategoryId = i.CategoryId,
                    IsAd = i.IsAd,
                })
                .ToList();
            return PartialView(urunler);
        }

        public ActionResult AboutUs ()
        {
            return View();
        }



    }
}