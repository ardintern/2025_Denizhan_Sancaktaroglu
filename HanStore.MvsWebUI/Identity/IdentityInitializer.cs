using HanStore.MvsWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if (!context.Roles.Any(i => i.Name == "superadmin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "superadmin", Description = "süper yönetici rolü" };

                manager.Create(role);
            }

            //Roller
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "yönetici rolü" };

                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };

                manager.Create(role);
            }
            
            //Kullanıcılar
            if (!context.Users.Any(i => i.Name == "denizhansan"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser{Name = "Denizhan", Surname = "Sancaktaroğlu", UserName = "denizhansan", Email = "denizhansan0@gmail.com"};

                var result = manager.Create(user, "325600");
                manager.AddToRole(user.Id, "superadmin");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");
            }

            if (!context.Users.Any(i => i.Name == "deniz"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { Name = "Deniz", Surname = "Sancak", UserName = "deniz", Email = "denizhan@gmail.com" };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }   



            base.Seed(context);
        }
    }
}