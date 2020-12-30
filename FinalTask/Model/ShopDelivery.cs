using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    /// <summary>
    /// Класс доставки до магазина
    /// </summary>
    class ShopDelivery : Delivery
    {
        public ShopDelivery(string address)
        {
            Address = address;
        }
        public override void SendOrder()
        {
            Console.WriteLine($"Доставка до магазина по адресу:{Address}");
        }
    }
}
