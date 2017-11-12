using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employé
{
    class Employee
    {
        protected String name;
        protected DateTime recruitmentDate;
        protected int age;

        public Employee(String name, int age, int year, int month, int day)
        {
            this.name = name;
            this.age = age;
            this.recruitmentDate = new DateTime(year, month, day);
        }

        public override String ToString()
        {
            return name + " " + age + " " + recruitmentDate.ToShortDateString();
        }

    }
}
