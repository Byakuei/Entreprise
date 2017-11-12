using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employé
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Roger", 27, 2015, 8, 1);
            Console.Write(employee1.ToString());

            Console.ReadKey();
        }
    }
}
