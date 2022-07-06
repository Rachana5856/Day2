using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_Topics
{
    public static class StatCalculator
    {       
        
            public static string Type = "Arithmetic";

            public static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
        
        static void Main(string[] args)
        {
            var result = StatCalculator.Sum(10, 25); // calling static method
            Console.WriteLine(result);

             // accessing static variable
            StatCalculator.Type = "Scientific";
            var calcType = StatCalculator.Type;// assign value to static variable
            Console.WriteLine(calcType);


            //Static Constructor and Default constructor

            stat_const st = new stat_const();
            stat_const st1 = new stat_const();


            //Ref and out parameter


            Console.ReadLine();
        }
    }


}
