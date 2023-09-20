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

        public void AddEmployee(Employee employee)
        {   
            employees.Add(employee);
        }

        public void RemoveEmployee(Guid id)
        {
            Employee employeeToRemove = employees.FirstOrDefault(employee => employee.ID == id);

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
            Console.WriteLine($"Id {employeeDetails.ID}, Name: {employeeDetails.FullName(employeeDetails)}, Role: {employeeDetails.Role}, Salary: {employeeDetails.Salary}, Date of Hire: {employeeDetails.DateOfHire}");
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine($"Employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Id: {employee.ID}, Name: {employee.FullName(employee)}, Role: {employee.Role}, Salary: {employee.Salary}, Date of Hire: {employee.DateOfHire}");
            }
        }
    }

}
