using HanStore.MvsWebUI.Entity;
using HanStore.MvsWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HanStore.MvsWebUI.Controllers
{
    public class CartController : Controller
    {
        private DataContext db = new DataContext();


        //Sepeti oluşturma (kişiye özel (session özelliği ile))
        public Cart GetCart()
        {
            var cart = (Cart)Session["cart"];

            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }

            return cart;
        }

        // Sepeti indexe çağırma
        public ActionResult Index()
        {
            return View(GetCart());
        }

        //Sepete ürün ekleme cart.cs deki AddProduct ile ürün 
        public ActionResult AddToCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();

            if (product != null) 
            { 
                GetCart().AddProduct(product, 1);
            }

            return RedirectToAction("Index", "Cart");
        }

        //Sepetten silme
        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();

            if (product != null)
            {
                GetCart().Delete(product,1);
            }

            return RedirectToAction("Index", "Cart");
        }

        public PartialViewResult Summary() 
        { 
        
        return PartialView(GetCart());

        }

        public ActionResult Checkout()
        {
            var model = new ShippingDetails();
            model.Cart = GetCart();

            if (model.Cart.CartLines.Count() == 0 || model == null)
            {
                ViewBag.UrunYokError = "Sepetinizde ürün bulunmamaktadır.";
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails entity)
        {
            var model = new ShippingDetails();

            model.Cart = GetCart();

            if (ModelState.IsValid)
            {
                //Sipariş işlemleri burada yapılacak
                SaveOrder(model, entity);

                model.Cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(model);
            }
        }

        private void SaveOrder(ShippingDetails cart, ShippingDetails entity)
        {
            
            var order = new Order();

            order.OrderNumber = "#"+(new Random()).Next(111111, 999999).ToString();
            order.Total = cart.Cart.Total();
            order.OrderDate = DateTime.Now;
            order.OrderState = EnumOrderState.Waiting;

            order.Username = User.Identity.Name;
            order.Username = entity.Username;
            order.Firstname = entity.Firstname;
            order.Surname = entity.Surname;

            order.AdresBasligi = entity.AdresBasligi;
            order.Adres = entity.Adres;
            order.Sehir = entity.Sehir;
            order.Semt = entity.Semt;
            order.Mahalle = entity.Mahalle;
            order.PostKodu = entity.PostKodu;
            

            order.OrderLines = new List<OrderLine>();

            foreach (var pr in cart.Cart.CartLines) 
            {
                var orderline = new OrderLine();
                orderline.Quantity = pr.Quantity;
                orderline.Price = Math.Round(pr.Quantity * pr.Product.Price,2);
                orderline.ProductId = pr.Product.Id;
             
                order.OrderLines.Add(orderline);
            }
        
            db.Orders.Add(order);
            db.SaveChanges();
        }
    }
}