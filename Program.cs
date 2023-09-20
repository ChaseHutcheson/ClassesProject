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
            Employee ChaseH = new Employee("Chase", "Hutcheson", "IT Services", 100000);
            restaurant.AddEmployee(ChaseH);
            restaurant.DisplayAllEmployees();
            Console.ReadKey();
        }
    }
}
