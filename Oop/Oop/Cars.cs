using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class Cars : Vehicles
    {
        [AforV(minprice = 600000)]
        public override void Двигатель()
        {
            throw new NotImplementedException();
        }
    }
}
