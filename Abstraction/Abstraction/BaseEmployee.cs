using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class BaseEmployee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetfullName()
        {
            return this.FirstName + " " + LastName;
        }

        public abstract int GetMonthlySalary();
    }
}
