using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    internal class Employee
    {
        // Fields
        private Guid id;
        private string firstName;
        private string lastName; 
        private string role;
        private int salary;
        private string dateOfHire;

        // Properties
        public Guid ID
        {
            get { return id; }
            set { id = Guid.NewGuid(); }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = DateTime.Now.ToString("dd/MM/yyyy"); }
        }

        public Employee(string initialFirstName, string initialLastName, string initialRole, int initialSalary)
        {
            string firstName = initialFirstName;
            string lastName = initialLastName;
            string role = initialRole;
            int salary = initialSalary;
        }

        public void Promote(Employee employee, int salary_increase)
        {
            employee.salary = employee.salary + salary_increase;
            Console.WriteLine($"Promoting {employee.firstName}...");
        }

        public void Demote(Employee employee, int salary_decrease)
        {
            employee.salary = employee.salary - salary_decrease;
            Console.WriteLine($"Demoting {employee.firstName}...");
        }

        public string FullName(Employee employee)
        {
            string employeeFullName = employee.id + " " + employee.lastName;
            return employeeFullName;
        }
    }
}
