using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Constants
{
    //Класс для глобальной переменной. 
    public static class Globals
    {
        private static int COUNTER = 1;

        public static int GetCounter()
        {
            return COUNTER;
        }
        public static void IncreaseCounter()
        {
            COUNTER++;
        }
    }
}
