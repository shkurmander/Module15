using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FinalTask.Constants;

namespace FinalTask.Model
{
    /// <summary>
    /// Класс заказа 
    /// </summary>
    /// <typeparam name="TDelivery">
    /// Тип доставки
    /// </typeparam>
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public string Number { get; set; }

        public Customer Customer { get; set; }

        public ArrayList PositionsList { get; set; }

        public TDelivery Delivering { get; set; }

        public Calculation Calculation { get; set; }

        public List<OrderState> State { get; set; }

        // Конструктор заказа
        public Order(Customer customer,
                     ArrayList positions,
                     Calculation calculation,
                     TDelivery delivering)
        {
            Number = Globals.GetCounter() + DateTime.Now.Year.ToString();       //Без использования БД или файлов, не придумал как организовать
            Globals.IncreaseCounter();                                          //счетчик, кроме как через глобальную переменную
           
            Customer = customer;
            PositionsList = positions;                            
           
            Calculation = calculation;                              
            State = new List<OrderState>();                           //создаем лист статусов заказа
            State.Add(new OrderState(CurrentOrderState.Created));   //Добавляем запись о создании заказа
        }
        public void ChangeState(OrderState orderState)
        {
            State.Add(orderState);
        }
        
    }
}
