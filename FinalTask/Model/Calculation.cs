using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FinalTask.Model
{
    /// <summary>
    /// Класс расчетов(чек по заказу)
    /// </summary>
    public class Calculation
    {
        private double Sum { get; set; }
        //private ArrayList PositionList { get; set; }
        //здесь можно разместить еще необходимые 
        //данные по расчетам, которые включить в чек
        //клнструктор просто "затычка" не хочется расписывать, т.к. сюда надо загонять список позиций для расчетов

        public Calculation (double sum)
        {
            Sum = sum;
        }
    }
}
