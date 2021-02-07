using System;
using System.Collections.Generic;
using System.Text;

namespace Gamer.OrderService
{
    interface IOrderService
    {
        void OrderAdd(Product product);
        void OrderDeleted(Product product);
        void OrderUpdate(Product product);

    }
}
