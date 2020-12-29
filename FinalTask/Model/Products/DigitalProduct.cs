using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    abstract class DigitalProduct : Product
    {
        private int Size { get; set; }
        private InformationUnits InfoUnit { get; set; }

        private string Link { get; set; }
    }
}
