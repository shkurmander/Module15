using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    class Toy : MaterialProduct
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }
        public DistanceUnits DistUnit { get; set; }

    }
}
