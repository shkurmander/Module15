using System;
using System.Collections.Generic;
using System.Text;
using FinalTask.Constants;


namespace FinalTask.Model
{
    class OrderState
    {
        public CurrentOrderState State ;
        private DateTime TimeStamp;

        public OrderState(CurrentOrderState state)
        {
            State = state;
            TimeStamp = DateTime.Now;
        }
    }

   
}
