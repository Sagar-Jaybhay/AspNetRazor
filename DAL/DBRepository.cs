using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class DBRepository : IEmployeeRepos
    {
        private List<Employee> _empList;
        public DBRepository()
        {
            _empList = new List<Employee>() {
                new Employee(){ Dept=Department.HR,Email="sagarjaybhay@gmail.com",ID="A101",Name="Sagar Jaybhay",Photopath=@"sagar jaybhay.png"},
                new Employee(){Dept=Department.IT,Email="rani@hotmail.com",ID="A201",Name="Rani",Photopath=@"rani.jpg" },
                new Employee(){ Dept=Department.Testing,Email="raja@gmail.com",ID="A301",Name="Raja",Photopath=@"ram.png"},
                new Employee(){ Dept=Department.Testing,Email="raghu@gmail.com",ID="A401",Name="Ragu",Photopath=""}

            };
            }


        public IEnumerable<Employee> GetAllEmployees()
        {
            return this._empList;
        }

        public Employee GetEmployee(string Id)
        {
            return this._empList.Where(s => s.ID.ToLower() == Id).SingleOrDefault();
        }
    }
}
