using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    /// <summary>
    /// Класс Даставка до квартиры
    /// </summary>
    public class HomeDelivery : Delivery 
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
