using System;
using System.Collections.Generic;
using System.Text;
using FinalTask.Constants;

namespace FinalTask.Model.Products
{
    /// <summary>
    /// Класс конкретного материального товара "Книга"
    /// </summary>
    class Book : MaterialProduct
    {
        private string Author { get; set; }
        private string Publisher { get; set; }
        private int Year { get; set; }
        private string Language { get; set; }
        private string Cover { get; set; }

        public Book(string id,
                    string name,
                    string description,
                    decimal price,
                    int weight,
                    WeightUnits unit,
                    double amt,
                    string author,
                    string publisher,
                    int year,
                    string language,
                    string cover)
        {
            Id = id;
            Name = name;
            Descripion = description;
            Price = price;
            Weight = weight;
            Unit = unit;
            Amt = amt;
            Author = author;
            Publisher = publisher;
            Year = year;
            Language = language;
            Cover = cover;

        }                

    }
}
