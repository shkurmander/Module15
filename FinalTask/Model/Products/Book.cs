﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    class Book : MaterialProduct
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Year { get; set; }
        public string Language { get; set; }
        public string Cover { get; set; }

    }
}
