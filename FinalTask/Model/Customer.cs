using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{   
    /// <summary>
    /// Класс покупателя
    /// </summary>
    public class Customer
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Country { get; set; }
        private string Email { get; set; }
        private string Phone { get; set; }

        //Конструктор объектов Customer, количество параметров больше рекомендуемых 4, но у нас же 
        //задача не про оптимизацию ;)
        public Customer(string name, string surname,string country, string email, string phone)
        {
            Name = name;
            Surname = surname;
            Country = country;
            Email = email;
            Phone = phone;
        }
    }
}
