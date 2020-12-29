using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model.Products
{
    /// <summary>
    /// Класс конкретного материального товара "книга"
    /// </summary>
    class Book : MaterialProduct
    {
        private string Author { get; set; }
        private string Publisher { get; set; }
        private int Year { get; set; }
        private string Language { get; set; }
        private string Cover { get; set; }

        public Book(string author, 
                    string publisher,
                    int year,
                    string language,
                    string cover,
                    )
        {
            Author = author;
            Publisher = publisher;
            Year = year;
            Language = language;
            Cover = cover;

        }                

    }
}
