using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Entity
{
    internal class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category {Name = "Tablet", Description = "Elektronik kategorisi"},
                new Category {Name = "Bilgisayar", Description = "Bilgisayar kategorisi"},
                new Category {Name = "Kulaklık", Description = "Kulaklık kategorisi"},
                new Category {Name = "Elektronik", Description = "Elektronik kategorisi"},
                new Category {Name = "Telefon", Description = "Akıllı telefon kategorisi"},
                new Category {Name = "Oyun", Description = "Oyun kategorisi"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product {Name = "Apple MacBook Pro", Description = "Apple'ın güçlü dizüstü bilgisayarı", Price = 1299.99, Stock = 30, IsApproved = true, CategoryId = 1, Image = "2.jpg", IsAd = true},
                new Product {Name = "Apple iPhone 13", Description = "Apple'ın en yeni akıllı telefonu", Price = 999.99, Stock = 100, IsApproved = true, CategoryId = 1, Image = "3.jpg", IsHome = true},
                new Product {Name = "Sony WH-1000XM4", Description = "Sony'nin en iyi kablosuz kulaklığı", Price = 349.99, Stock = 75, IsApproved = true, CategoryId = 1, Image = "4.jpg", IsAd = true},
                new Product {Name = "LG Gram 17", Description = "LG'nin hafif ve büyük ekranlı dizüstü bilgisayarı", Price = 1499.99, Stock = 20, IsApproved = true, CategoryId = 1, Image = "5.jpg"},

                new Product {Name = "Dell XPS 13", Description = "Dell'in ince ve hafif dizüstü bilgisayarı", Price = 1199.99, Stock = 20, IsApproved = true, CategoryId = 2, Image = "6.jpg"},
                new Product {Name = "Samsung Galaxy S21", Description = "Samsung'un en yeni amiral gemisi telefonu", Price = 799.99, Stock = 80, IsApproved = true, CategoryId = 2, Image = "7.jpg"},
                new Product {Name = "Microsoft Surface Pro 7", Description = "Microsoft'un 2'si 1 arada cihazı", Price = 899.99, Stock = 40, IsApproved = true, CategoryId = 2, Image = "8.jpg"},
                new Product {Name = "Apple iPad Air", Description = "Apple'ın hafif ve güçlü tableti", Price = 599.99, Stock = 60, IsApproved = true, CategoryId = 2, Image = "9.jpg"},
                new Product {Name = "Amazon Echo Dot", Description = "Amazon'un akıllı hoparlörü", Price = 49.99, Stock = 200, IsApproved = true, CategoryId = 2, Image = "10.jpg"},

                new Product {Name = "Google Pixel 6", Description = "Google'ın en yeni akıllı telefonu", Price = 699.99, Stock = 90, IsApproved = true, CategoryId = 3, Image = "11.jpg"},
                new Product {Name = "HP Spectre x360", Description = "HP'nin şık ve güçlü dizüstü bilgisayarı", Price = 1399.99, Stock = 25, IsApproved = true, CategoryId = 3, Image = "12.jpg", IsHome = true, IsAd = true},
                new Product {Name = "Bose QuietComfort 35 II", Description = "Bose'un kablosuz gürültü önleyici kulaklığı", Price = 299.99, Stock = 55, IsApproved = true, CategoryId = 3, Image = "13.jpg", IsAd = true}, 
                new Product {Name = "Lenovo ThinkPad X1 Carbon", Description = "Lenovo'nun iş odaklı dizüstü bilgisayarı", Price = 1499.99, Stock = 15, IsApproved = true, CategoryId = 3, Image = "14.jpg"},
                new Product {Name = "JBL Flip 5", Description = "JBL'in taşınabilir kablosuz hoparlörü", Price = 89.99, Stock = 150, IsApproved = true, CategoryId = 3, Image = "15.jpg", IsHome = true},

                new Product {Name = "OnePlus 9", Description = "OnePlus'ın hızlı şarj özellikli akıllı telefonu", Price = 749.99, Stock = 70, IsApproved = true, CategoryId = 4, Image = "16.jpg", IsHome = true, IsAd = true},
                new Product {Name = "Asus ROG Zephyrus G14", Description = "Asus'un oyun odaklı dizüstü bilgisayarı", Price = 1599.99, Stock = 10, IsApproved = true, CategoryId = 4, Image = "17.jpg"},
                new Product {Name = "Amazon Kindle Paperwhite", Description = "Amazon'un su geçirmez e-kitap okuyucusu", Price = 129.99, Stock = 120, IsApproved = true, CategoryId = 4, Image = "18.jpg", IsHome = true},
                new Product {Name = "Xiaomi Mi 11", Description = "Xiaomi'nin amiral gemisi akıllı telefonu", Price = 699.99, Stock = 85, IsApproved = true, CategoryId = 4, Image = "19.jpg"},
                
                new Product {Name = "Huawei Mate XT", Description = "Huawei'nin yenilikçi telefonu", Price = 2199.99, Stock = 5, IsApproved = true, CategoryId = 5, IsHome = true, IsAd = true}
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();


            base.Seed(context);
        }
    }
}