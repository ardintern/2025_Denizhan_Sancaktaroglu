using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        //Data Annotations
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength: 20, ErrorMessage = "Kategori adı çok uzun.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}