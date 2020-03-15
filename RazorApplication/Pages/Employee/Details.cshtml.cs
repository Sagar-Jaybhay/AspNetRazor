using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApplication.Pages.Employee
{
    public class DetailsModel : PageModel
    {
        public RazorPages.Models.Employee employee;
        public DetailsModel(IEmployeeRepos employeeRepos)
        {
            EmployeeRepos = employeeRepos;
        }

        public IEmployeeRepos EmployeeRepos { get; }
       
        [BindProperty(SupportsGet = true)]
        public string ID { get; set; }
        
        public void OnGet(string id)
        {
            
            employee = this.EmployeeRepos.GetEmployee(id);

        }
    }
}