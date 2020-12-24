using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;


namespace FinalTask.Model
{
    abstract class MaterialProduct : Product
    {
        public int Weight { get; set; }

        public WeightUnits  Unit { get; set; }

        public double Amt { get; set; }


    }
}
