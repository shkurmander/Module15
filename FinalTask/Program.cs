using FinalTask.Model;
using System;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var order1 = OrderController.NewOrder();
            order1.ChangeState(new OrderState(Constants.CurrentOrderState.Confirmed));

        }
    }
}
