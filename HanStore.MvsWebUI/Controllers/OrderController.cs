using HanStore.MvsWebUI.Entity;
using HanStore.MvsWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;

namespace HanStore.MvsWebUI.Controllers
{
    [Authorize (Roles = "admin")]
    public class OrderController : Controller
    {
        private DataContext db = new DataContext();

        [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            var orders = db.Orders.Select(i => new AdminOrderModel() 
            { 
            Id = i.Id,
            Total = i.Total,
            OrderDate = i.OrderDate,
            OrderState = i.OrderState,
            OrderNumber = i.OrderNumber, 
            Count = i.OrderLines.Count() //siparişin içinde kaç ürün (orderline) var
            }).OrderByDescending(i => i.OrderDate).ToList();

            return View(orders);
        }

        public ActionResult Details (int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
                    Username = i.Username,
                    OrderId = i.Id,
                    OrderNumber = i.OrderNumber,
                    Total = i.Total,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    AdresBasligi = i.AdresBasligi,
                    Adres = i.Adres,
                    Sehir = i.Sehir,
                    Semt = i.Semt,
                    Mahalle = i.Mahalle,
                    PostKodu = i.PostKodu,
                    OrderLines = i.OrderLines.Select(a => new OrderLineModel()
                    {
                        ProductName = a.Product.Name.Length > 30 ? a.Product.Name.Substring(0, 30) + "..." : a.Product.Name,
                        ProductId = a.ProductId,
                        Quantity = a.Quantity,
                        Price = a.Price,
                        Image = a.Product.Image,
                    }).ToList()
                }).FirstOrDefault();
            return View(entity);
        }
        public ActionResult UpdateOrderState(int OrderId, EnumOrderState orderState)
        {
            var order = db.Orders.FirstOrDefault(i => i.Id == OrderId);

            if (order != null)
            {
                order.OrderState = orderState;
                db.SaveChanges();

                TempData["message"] = "Sipariş durumu güncellendi.";

                return RedirectToAction("Details", new { id = OrderId });
            }
            return RedirectToAction("Index");
        }

    }
}