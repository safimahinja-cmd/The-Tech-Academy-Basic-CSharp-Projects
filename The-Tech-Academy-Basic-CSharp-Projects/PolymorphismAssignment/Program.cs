using System;

// This namespace groups all types for the Polymorphism assignment console app.
namespace PolymorphismAssignment
{
    // This class contains the application entry point.
    class Program
    {
        // This method is where the console application starts running.
        static void Main(string[] args)
        {
            // This creates an Employee object and stores it in an interface-typed variable to demonstrate polymorphism.
            IQuittable quittableEmployee = new Employee("Jane", "Doe", 101);

            // This calls the interface method on the interface reference, which executes Employee.Quit().
            quittableEmployee.Quit();
        }
    }
}
