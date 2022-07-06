using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Topics
{
    class stat_const
    {
        static stat_const()
        {
            Console.WriteLine("Static Constructor is called only once");
            //Called in StatCalculator Main method
        }

        public stat_const()
        {
            Console.WriteLine("Default Constructor is called as many objects created");
            //Called in StatCalculator Main method
        }
    }
}
