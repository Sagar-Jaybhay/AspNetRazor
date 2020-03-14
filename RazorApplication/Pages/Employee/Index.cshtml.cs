using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApplication.Pages.Employee
{
    public class IndexModel : PageModel
    {
        public List<RazorPages.Models.Employee> Employees;
        public IndexModel(IEmployeeRepos employeeRepos)
        {
            EmployeeRepos = employeeRepos;
        }

        public IEmployeeRepos EmployeeRepos { get; }

        public void OnGet()
        {
            Employees = EmployeeRepos.GetAllEmployees().ToList();          
        }
    }
}