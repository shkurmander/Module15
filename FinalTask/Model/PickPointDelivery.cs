﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string address)
        {
            Address = address;
        }
        public override void SendOrder()
        {
            Console.WriteLine($"Доставка до точки выдачи по адресу:{Address}");
        }
    }
}
