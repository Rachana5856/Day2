using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            FulltimeEmployee fte = new FulltimeEmployee();
            fte.id = 1;
            fte.FirstName = "John";
            fte.LastName = "Reigns";
            fte.AnnualSalary = 500000;
            fte.GetfullName();
            fte.GetMonthlySalary();
            Console.WriteLine(fte.GetfullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("---------------------------------------------------");


            ContractEmployee cte = new ContractEmployee();
            cte.id = 1;
            cte.FirstName = "Harry";
            cte.LastName = "Reigns";
            cte.HourlyPay = 2300;
            cte.TotalHours = 80;
            cte.GetfullName();
            cte.GetMonthlySalary();
            Console.WriteLine(cte.GetfullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.ReadLine();
        }
    }
}
