using HanStore.MvsWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Models
{
    public class OrderDetailsModel
    {
        public string Username { get; set; }
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }

        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostKodu { get; set; }

        public List<OrderLineModel> OrderLines { get; set; }
    }

    public class OrderLineModel
    {
        public string Image { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
    }
}