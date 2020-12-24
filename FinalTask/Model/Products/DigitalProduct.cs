using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    abstract class DigitalProduct : Product
    {
        public int Size { get; set; }
        public InformationUnits InfoUnit { get; set; }

        public string Link { get; set; }
    }
}
