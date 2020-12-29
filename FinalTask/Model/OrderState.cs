using System;
using System.Collections.Generic;
using System.Text;
using FinalTask.Constants;


namespace FinalTask.Model
{
    /// <summary>
    /// Класс Статуса заказа - Статус + Таймстамп
    /// При рефакторинге, скорее всего выкинул бы этот класс и сделал бы таймстамп напрямую без него
    /// </summary>
    class OrderState
    {
        private CurrentOrderState State ;
        private DateTime TimeStamp;

        public OrderState(CurrentOrderState state)
        {
            State = state;
            TimeStamp = DateTime.Now;
        }
    }

   
}
