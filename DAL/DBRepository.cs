using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DBRepository : IEmployeeRepos
    {
        private List<Employee> _empList;
        public DBRepository()
        {
            _empList = new List<Employee>() {
                new Employee(){ Dept=Department.HR,Email="s@s.com",ID="A101",Name="sagar Jaybhay",Photopath=""},
                new Employee(){Dept=Department.IT,Email="XYZ@XYZ.com",ID="A201",Name="XYZ",Photopath="" },
                new Employee(){ Dept=Department.Testing,Email="ABC@ABC.com",ID="A301",Name="ABC",Photopath=""}
                };
            }


        public IEnumerable<Employee> GetAllEmployees()
        {
            return this._empList;
        }
    }
}
