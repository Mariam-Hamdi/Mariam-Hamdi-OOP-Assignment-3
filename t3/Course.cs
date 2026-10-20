using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t3
{
   public class Course : IHasId
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}
