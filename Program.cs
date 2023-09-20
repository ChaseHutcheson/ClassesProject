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
            restaurant.AddEmployee("Chase", "Hutcheson", "IT Services", 1000000);
            restaurant.DisplayAllEmployees();
            Console.ReadLine();
        }
    }
}
