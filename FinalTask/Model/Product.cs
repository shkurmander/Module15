using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    /// <summary>
    /// Корневой абстрактный класс товара
    /// </summary>
    abstract class Product
    {
        protected string Id;

        protected string Name { get; set; }

        protected string Descripion { get; set; }

        protected decimal Price { get; set; }
      
    }
}
