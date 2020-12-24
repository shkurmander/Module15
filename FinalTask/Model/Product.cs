using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    abstract class Product
    {
        public string Id;

        public string Caption { get; set; }

        public string Descripion { get; set; }

        public decimal Price { get; set; }

    }
}
