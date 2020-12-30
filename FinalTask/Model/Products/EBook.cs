using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    /// <summary>
    /// Класс конкретного цифрового товара "электронная книга"
    /// </summary>
    class EBook : DigitalProduct
    {
        private string Author { get; set; }
        private string Publisher { get; set; }
        private int Year { get; set; }
        private string Language { get; set; }

        public EBook(string id,
                    string name,
                    string description,
                    decimal price,
                    int size,
                    InformationUnits infoUnit,
                    string link,
                    string author,
                    string publisher,
                    int year,
                    string language)
        {
            Id = id;
            Name = name;
            Descripion = description;
            Price = price;
            Size  = size;
            InfoUnit = InfoUnit;
            Link = link;
            Author = author;
            Publisher = publisher;
            Year = year;
            Language = language;
        }
    }
}
