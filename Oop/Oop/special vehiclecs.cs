using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class special_vehiclecs : Vehicles, Interface1
    {
        public string srt;
        public override void Двигатель()
        {
            throw new NotImplementedException();
        }

        public void специалная_надстройка(string тип, string производитель)
        {
            srt = "Тип " + тип + " производитель " + производитель;
        }
    }
}
