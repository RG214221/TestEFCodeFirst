using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFCodeFirst
{
    public class CyclicTask:TaskToDo
    {
        public int DayInWeek { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + DayInWeek;
        }
    }
}
