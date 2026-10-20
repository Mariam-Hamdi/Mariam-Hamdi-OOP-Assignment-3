using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t1._1
{
    public class NewCarrier:IShippingCarrier
    {
        public decimal Calculate(decimal weightKg) => weightKg * 20m;
    }
}
