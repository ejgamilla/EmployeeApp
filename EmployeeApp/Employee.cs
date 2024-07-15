using System;

namespace EmployeeApp
{
    // Define an Employee class that inherits from IQuittable
    public class Employee : IQuittable
    {
        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            // Display a message indicating that the employee has quit
            Console.WriteLine("The employee has quit the job.");
        }
    }
}
