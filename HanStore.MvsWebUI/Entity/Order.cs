using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Entity
{
    public class Order
    {
        public string ProductName { get; set; }
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
        public EnumOrderState OrderState { get; set; }

        //Aldığı zamanki verilerin gösterilmesi için tekrardan yazdık
        //yoksa bu veriler kullanıcı ürünü aldıktan sonra da güncellenir.
        //Alttaki Price için de aynısı geçerli
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }

        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Semt { get; set; }
        public string Mahalle { get; set; }
        public string PostKodu { get; set; }
        public List<OrderLine> OrderLines { get; set; }
    }


    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}