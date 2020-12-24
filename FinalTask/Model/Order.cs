using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    class Order<TDelivery>  where TDelivery : Delivery
    {
        public string Number { get; set; }
        
        public Customer Customer { get; set; }        
        
        public List<Position> PositionsList { get; set; }
        
        public TDelivery Delivery { get; set; } 
        
        public Calculation Calculation { get; set; }
        
        public List<OrderState> State { get; set; }       
        

    }
}
