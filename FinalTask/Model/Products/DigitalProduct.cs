using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    /// <summary>
    /// Абстрактный класс цифрового товара
    /// </summary>
    abstract class DigitalProduct : Product
    {
        protected int Size { get; set; }
        protected InformationUnits InfoUnit { get; set; }

        protected string Link { get; set; }
    }
}
