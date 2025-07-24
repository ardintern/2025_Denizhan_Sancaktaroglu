using HanStore.MvsWebUI.Entity;
using HanStore.MvsWebUI.Identity;
using HanStore.MvsWebUI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace HanStore.MvsWebUI.Controllers
{
    public class AccountController : Controller
    {
        private DataContext db = new DataContext();

        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager = new RoleManager<ApplicationRole>(roleStore);

        }

        // Index
        [Authorize(Roles = "user,admin,superadmin")]
        public ActionResult Order()
        {
            var username = User.Identity.Name;
            var orders = db.Orders.Where(i => i.Username == username)
                .Select(i => new UserOrderModel()
                {
                    Id = i.Id,
                    OrderNumber = i.OrderNumber,
                    OrderDate = i.OrderDate,
                    OrderState = i.OrderState,
                    Total = i.Total,

                }).OrderByDescending(i => i.OrderDate).ToList();



            return View(orders);
        }

        public ActionResult Index()
        {
            return View();
        }

        //Details
        [Authorize(Roles = "user,admin")]
        public ActionResult Details(int id)
        {
            var entity = db.Orders.Where(i => i.Id == id)
                .Select(i => new OrderDetailsModel()
                {
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

        // Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register Model)
        {
            if (ModelState.IsValid)
            {

                var user = new ApplicationUser();
                user.Name = Model.Name;
                user.Surname = Model.Surname;
                user.UserName = Model.UserName;
                user.Email = Model.Email;

                IdentityResult result = UserManager.Create(user, Model.Password);

                if (result.Succeeded)
                {
                    //Kullanıcı oluştu ve kullanıcıyı bir role atayabiliriz.
                    if (RoleManager.RoleExists("User"))
                    {
                        UserManager.AddToRole(user.Id, "User");
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturulamadı.");
                }

            }

            return View(Model);
        }


        // Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login Model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                // Login işlemleri
                var user = UserManager.Find(Model.UserName, Model.Password);

                if (user != null)
                {
                    // Varolan kullanıcıyı sisteme dahil et
                    // ApplicationCookie oluşturup sisteme bırak

                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = Model.RememberMe;

                    authManager.SignIn(authProperties, identityclaims);

                    if (!string.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok.");
                }
            }

            return View(Model);
        }


        // Logout
        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();


            return RedirectToAction("Index", "Home");
        }

        //public ActionResult UpdateUserProfile(int UserId, ProfileUpdate profile)
        //{
        //    var user = db.ProfileUpdates.FirstOrDefault(i => i.UserId == UserId);

        //    user.UserId = profile.UserId;
        //    user.Name = profile.Name;
        //    user.Surname = profile.Surname;
        //    user.Email = profile.Email;
        //    user.OldPassword = profile.OldPassword;


        //    if (user != null)
        //    {
        //        user.
        //        db.SaveChanges();

        //        TempData["message"] = "Sipariş durumu güncellendi.";

        //        return RedirectToAction("Details", new { id = OrderId });
        //    }
        //    return RedirectToAction("Index");

        //}
    }
}