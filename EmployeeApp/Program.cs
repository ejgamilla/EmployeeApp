using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();

            // Call the Quit method on the object
            quittableEmployee.Quit();

            // Prevent the console from closing immediately
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
