using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employé
{
    class Company
    {


        private int _idCompany;
        private List<Employee> _listEmployee;
        private String _nameCompany;
        private int _numberEmployee;



        public Company(String name,List<Employee> listE, int id)
        {
            this._idCompany = id;
            this._nameCompany = name;
            this._listEmployee = new List<Employee>(listE);
            this._numberEmployee = listE.Count;
        }





        #region Methods
        /// <summary>
        /// This method add an employee(directly given in parameter) into the list
        /// </summary>
        /// <param name="e"></param>
        public void addEmployee(Employee e)
        {
            this._listEmployee.Add(e);
        }

        /// <summary>
        /// Allow you to delete an employee by searching him direclty in the list
        /// </summary>
        /// <param name="e"></param>
        public void deleteEmployee(Employee e)
        {
         
        }

        /// <summary>
        /// Allow you to delete an employee by his index in the list
        /// </summary>
        /// <param name="index"></param>
        public void deleteEmployee(int index)
        {

        }

        /// <summary>
        /// Search an employee in the list and return the indexe
        /// </summary>
        /// <param name="e">The corresponding employee to search</param>
        /// <returns>Return the index if founded, else -1</returns>
        public int searchEmployee(Employee e)
        {
            int indexe = -1;

            return indexe;
        }

        #endregion

        #region Properties
        public int IdCompany
        {
            get
            { return _idCompany; }
        }


        #endregion

    }
}
