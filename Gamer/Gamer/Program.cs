using Gamer.KampanyaService;
using Gamer.OrderService;
using System;

namespace Gamer
{
    class Program
    {
         static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewCheckService());
            gamerManager.Add(new Gamer
            {
                GamerName = "İsmail",
                GamerLastName = "Kılın",
                NationalId = 180,
                DateTime = 1999
            });
            
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaAdd(new Kampanya
            {
                KampanyaId = 12846,
                KampanyaName = "EfsaneCuma",
                KampanyaDetay = "12 Şubata kadar geçerli"
            });
            OrderManager orderManager = new OrderManager();
            orderManager.OrderAdd(new Product
            {
                ProductId = 25,
                ProductName = "GTA V",
                ProductStocks = 12,
                UnitePrice = 180
            });











            

        }
    }
}
