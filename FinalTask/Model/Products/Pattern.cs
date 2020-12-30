using FinalTask.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    /// <summary>
    /// Класс кокнретного цифрового товара "Шаблон(мастер-класс)"
    /// </summary>
    class Pattern : DigitalProduct
    {
        private string Author { get; set; }
        private string Language { get; set; }

        public Pattern(string id,
                  string name,
                  string description,
                  decimal price,
                  int size,
                  InformationUnits infoUnit,
                  string link,
                  string author,
                  string language)
        {
            Id = id;
            Name = name;
            Descripion = description;
            Price = price;
            Size = size;
            InfoUnit = InfoUnit;
            Link = link;
            Author = author;
            Language = language;
        }
    }
}
