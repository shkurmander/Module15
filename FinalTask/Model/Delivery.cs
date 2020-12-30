using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    /// <summary>
    /// Родительский абстрактный класс доставки
    /// </summary>
    abstract class Delivery
    {
        public string Address;

        public abstract void SendOrder();
    }
}
