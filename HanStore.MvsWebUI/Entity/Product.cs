using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
        [DisplayName("Stok Adedi")]
        public int Stock { get; set; }
        [DisplayName("Stok Durumu")]
        public bool IsApproved { get; set; }
        [DisplayName("Ana Sayfada Göster")]
        public bool IsHome { get; set; }
        [DisplayName("Reklam Olarak Göster")]
        public bool IsAd { get;      set; }
        [DisplayName("Kategori Id")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }


}