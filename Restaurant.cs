using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    public class Restaurant
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(string firstName, string lastName, string role, int salary)
        {
            // Generate a unique ID for the new employee
            Guid randomId;
            do
            {
                randomId = Guid.NewGuid();
            } while (employees.Any(employee => employee.ID == randomId));

            // Create a new employee and add them to the list
            Employee newEmployee = new Employee
            {
                ID = randomId,
                FirstName = firstName,
                LastName = lastName,
                Role = role,
                Salary = salary
            };
            employees.Add(newEmployee);
        }

        public void RemoveEmployee(Guid id)
        {
            Employee employeeToRemove = employees.FirstOrDefault(employee => employee.id == id);

            if (employeeToRemove != null)
            {
                Console.WriteLine("Removing Employee...");
                employees.Remove(employeeToRemove);
            }
            else
            {
                Console.WriteLine("Employee doesnt exist");
            }
        }

        public void GetEmployee(Guid id)
        {
            Employee employeeDetails = employees.FirstOrDefault(employee => employee.ID == id);
            Console.WriteLine($"Id {employeeDetails.ID}, Name: {employeeDetails.FullName(employeeDetails)}, Role: {employeeDetails.Role}, Salary: {employeeDetails.salary}, Date of Hire: {employeeDetails.dateOfHire}");
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine($"Employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Id {employee.id}, Name: {employee.FullName(employee)}, Role: {employee.role}, Salary: {employee.salary}, Date of Hire: {employee.dateOfHire}");
            }
        }
    }

}
