using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employé
{
    class Employee
    {
        protected String _name;
        protected DateTime _recruitmentDate;
        protected int _age;

        public Employee(String name, int age, int year, int month, int day)
        {
            this._name = name;
            this._age = age;
            this._recruitmentDate = new DateTime(year, month, day);
        }

        public override String ToString()
        {
            return _name + " " + _age + " " + _recruitmentDate.ToShortDateString(); // ToShortDateString to not show hh:mm:ss
        }

    }
}
