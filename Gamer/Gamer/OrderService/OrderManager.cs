using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.OrderService
{
    class OrderManager : IOrderService
    {
        public void OrderAdd(Product product)
        {
            Console.WriteLine("siparişiniz sepetinize eklendi " + product.ProductName + product.ProductId + product.ProductStocks + product.UnitePrice);
        }

        public void OrderDeleted(Product product)
        {
            Console.WriteLine("siparişiniz sepetinizden çıkarıldı");

        }

        public void OrderUpdate(Product product)
        {
            Console.WriteLine("siparişiniz değiştirildi");

        }
    }
}
