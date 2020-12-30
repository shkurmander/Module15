using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    /// <summary>
    /// Класс позиции товара
    /// </summary>
    /// <typeparam name="TProduct"> 
    /// Тип товара
    /// </typeparam>
    class Position<TProduct> where TProduct : Product
    {
        private TProduct Product { get; set; }
        private int Amount { get; set; }

        //Конструктор объекта Position
        public Position(TProduct product, int amount)
        {
            Product = product;
            Amount = amount;
        }        
    }
    
 
}
