using FinalTask.Model;
using FinalTask.Model.Products;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinalTask
{
    public static class OrderController
    {
        public static void NewOrder() 
        {
            var order1 = new Order<HomeDelivery>(GetCustomer(), GetPositionsList(), GetCalculation());
        }
        //Метод возвращающий объект покупателя
        public static Customer GetCustomer()
        {

            //Здесь надо сделать интерактив по вводу нового покупателя

           return new Customer("Анна", "Иванова", "Белоруссия", "aiva@mail.ru", "+7925123456");

            
        }
        //Метод возвращающий список позиций
        public static ArrayList GetPositionsList()
        {
            //Запрашиваем товары у метода GetProduct и добавляем в список
            ArrayList positionList = new ArrayList();
            positionList.Add(GetProduct("Книга"));
            positionList.Add(GetProduct("ebook"));

            return positionList;
        }
        
        //Метод возвращающий объект конкретного класса товара
        //параметр в методе только временно, чтобы вернуть разные объекты, хотя... можно потом сделать справочник 
        // товаров и предложить выбор какой товар нужен, но это уже не в данном задании ...
        private static Product GetProduct(string type)
        {
            switch (type)
            {
                case "Книга":
                    return new Book("Ф-1",
                                    "Ведьмак. Кровь эльфов",
                                    "Продолжение приключений Геральта из Ривии",
                                    499.00M,
                                    262,
                                    Constants.WeightUnits.g,
                                    20,
                                    "Анджей Сапковский",
                                    "Астрель",
                                    2017,
                                    "Русский",
                                    "7Бц - твердая");
                case "ebook":
                    return new EBook("КН-1",
                                    "Head First C#",
                                    "Head First C# is a complete learning experience for learning how to program with C#, XAML, the .NET Framework, and Visual Studio. Fun and highly visual, this introduction to C# is designed to keep you engaged and entertained from first page to last.",
                                    1650.00M,
                                    124,
                                    Constants.InformationUnits.Mb,
                                    "https://www.ozon.ru/context/detail/id/25358353/#section-description--offset-80",
                                    "Jennifer Greene, Andrew Stellman",
                                    "O'Reilly Media",
                                    2013,
                                    "English");
                default: 
                    return null;
            }
        }

        //Метод возвращающий данные и расчеты которые пойдут в чек.
        //Метод не писал польностью т.к. он сложный и объемный, потому просто "затычка"
        //А так ему еще надо список позиций параметром передать
        public static Calculation GetCalculation()
        {
            return new Calculation(2149);
        }

        public static void PrintOrder(Order<Delivery> order)
        {
            Console.WriteLine($"Номер заказа: {order.Number}");
            Console.WriteLine($"Покупатель: {order.Customer.");

        }
    }
}
