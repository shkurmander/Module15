using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    abstract class Delivery
    {
        public string Address;

        public abstract void SendOrder();
    }
}
