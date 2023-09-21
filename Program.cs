using ClassesProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            Employee JohnDoe = new Employee("John", "Doe", "Chef", 50000);
            Employee JaneDoe = new Employee("Jane", "Doe", "Waiter", 3000);
            restaurant.AddEmployee(JohnDoe);
            restaurant.AddEmployee(JaneDoe);
            Console.WriteLine($"Employees:");
            restaurant.DisplayAllEmployees();
            Console.WriteLine($"\nPromoting Jane...");
            JaneDoe.Promote(3000);
            restaurant.DisplayAllEmployees();
            Console.WriteLine($"\nPromoting Jane again...");
            JaneDoe.Promote(3000);
            restaurant.DisplayAllEmployees();
            Console.WriteLine("\nRemoving John...");
            restaurant.RemoveEmployee(JohnDoe.ID);
            restaurant.DisplayAllEmployees();
            Console.ReadKey();
        }
    }
}
