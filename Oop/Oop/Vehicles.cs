using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    abstract class Vehicles
    {
        [AforV(minprice = 4000)]
        public string марка;
        public string модель;
        public int количество_мест;
        public abstract void Двигатель();
        public void getМаркаМодель() 
        {
            Console.WriteLine("Марка {0}, Модель {1}", марка, модель);
        }
    }
}
