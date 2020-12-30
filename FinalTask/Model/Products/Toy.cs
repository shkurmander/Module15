using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    /// <summary>
    /// Класс конкретного товара "Игрушка"
    /// </summary>
    class Toy : MaterialProduct
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private int Depth { get; set; }
        private DistanceUnits DistUnit { get; set; }
        private Toy(string id,
                    string name,
                    string description,
                    decimal price,
                    int weight,
                    WeightUnits unit,
                    double amt,
                    int width,
                    int height,
                    int depth,
                    DistanceUnits distUnit) 
        {
            Id = id;
            Name = name;
            Descripion = description;
            Price = price;
            Weight = weight;
            Unit = unit;
            Amt = amt;
            Width = width;
            Height = height;
            Depth = depth;
            DistUnit = distUnit;
        }
    }
    

}
