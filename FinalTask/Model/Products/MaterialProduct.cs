using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;


namespace FinalTask.Model
{
    /// <summary>
    /// Абстрактный класс материального продукта
    /// </summary>
    abstract class MaterialProduct : Product
    {
        protected int Weight { get; set; }

        protected WeightUnits  Unit { get; set; }

        protected double Amt { get; set; }
       
    }
}
