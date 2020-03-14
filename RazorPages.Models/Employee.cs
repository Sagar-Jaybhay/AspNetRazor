using System;

namespace RazorPages.Models
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photopath { get; set; }
        public Department? Dept { get; set; }

    }

    public enum Department
    {
        IT, HR, Support,Testing,Account
    }
}
