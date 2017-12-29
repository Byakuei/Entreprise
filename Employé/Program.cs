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
            Console.WriteLine("What do you want to do ?\n\n");
            Console.WriteLine("-Create a new company : type 1\n-Load data of an existing company: tapez 2");

            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice==1)
            {
                Console.WriteLine("What's your company's name ?");
                string name = Console.ReadLine();
                Console.WriteLine("How many employee does your company have ?");
                int numberEmployee = Convert.ToInt32(Console.Read());
            }
            else
            {
                Console.WriteLine();
                
            }
            

            Console.ReadKey();
        }
    }
}
