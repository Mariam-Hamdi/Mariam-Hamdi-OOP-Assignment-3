using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t1._1
{
    public interface IShippingCarrier
    {
        public decimal Calculate(decimal weightKg); 

    }
   public class Aramex:IShippingCarrier
    {
        public decimal Calculate(decimal weightKg) => weightKg * 12m;
    }
    public class FedEx : IShippingCarrier
    {
        public decimal Calculate(decimal weightKg) => weightKg * 15m;
    }
    public class DHL : IShippingCarrier
    {
        public decimal Calculate( decimal weightKg) => weightKg * 18m;
    }
}
