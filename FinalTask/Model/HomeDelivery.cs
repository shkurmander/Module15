using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    class HomeDelivery : Delivery
    {
        public HomeDelivery(string address)
        {
            Address = address;
        }
        public override void  SendOrder()
        {
            Console.WriteLine($"Доставка до квартиры по адресу:{Address}");
        }            

    }
}
