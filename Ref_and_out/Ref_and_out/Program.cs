using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_and_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int refa = 10;
            int outa = 30;
            Console.WriteLine("RefA : "+refa);
            Console.WriteLine("OutA : " + outa);
            RefExample(ref refa, out outa);
            Console.WriteLine("RefA : " + refa);          
            Console.WriteLine("OutA : " + outa);
            Console.ReadLine();
        }

        static void RefExample(ref int refb, out int outb)
        {
            refb = 20;
            outb = 40;
        }
    }
}
