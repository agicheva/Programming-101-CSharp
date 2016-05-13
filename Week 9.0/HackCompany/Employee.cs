using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackCompany
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? ManagerId { get; set; }
        public int? DepartmentId { get; set; }

        public Employee(int employeeId, string firstName, string lastName, string email, DateTime dateOfBirth, int? managerId, int? departmentId)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            ManagerId = managerId;
            DepartmentId = departmentId;
        }
    }
}
