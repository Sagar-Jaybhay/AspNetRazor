using RazorPages.Models;

using System.Collections.Generic;

namespace DAL
{
    public interface IEmployeeRepos
    {
        IEnumerable<Employee> GetAllEmployees();
    }

}
