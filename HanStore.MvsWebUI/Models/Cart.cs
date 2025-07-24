using HanStore.MvsWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HanStore.MvsWebUI.Models
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        //Ürün ekleme işlemi
        public void AddProduct(Product product, int quantity) 
        {
            var line = _cardLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
        
            if (line == null)
            {
                _cardLines.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }

        }

        //Sepetteki ürünleri temizleme işlemi
        public void DeleteProduct(Product product) 
        {
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);

        }

        //Sepetteki ürünlerin toplam fiyatını hesaplama işlemi
        public double Total()
        {
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);
        }

        //Sepetteki bütün ürünleri silme işlemi
        public void Clear()
        { 
            _cardLines.Clear();
        }

        public int TotalCart()
        {
            
            return _cardLines.Sum(i => i.Quantity);
        }

        //Ürünü sepetten silme (tek tek)
        public void Delete(Product product, int quantity)
        {
            var line = _cardLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();

            if (line != null)
            {
                if (line.Quantity == 1)
                {
                    _cardLines.RemoveAll(i => i.Product.Id == product.Id);
                }
                if (line.Quantity > 1)
                {
                    line.Quantity -= quantity;
                }
            }
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}