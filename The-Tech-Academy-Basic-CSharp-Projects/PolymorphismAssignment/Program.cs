using System;

// This namespace groups the interface, classes, and program entry point for the polymorphism assignment.
namespace TheTechAcademyBasicCSharpProjects
{
    // This interface defines the contract that any quittable object must follow.
    interface IQuittable
    {
        // This method signature requires implementing classes to provide quit behavior.
        void Quit();
    }

    // This class represents an employee and implements the quittable behavior defined by the interface.
    class Employee : IQuittable
    {
        // This auto-property stores the employee's first name.
        public required string FirstName { get; set; }

        // This auto-property stores the employee's last name.
        public required string LastName { get; set; }

        // This auto-property stores the employee's numeric identifier.
        public int Id { get; set; }

        // This method fulfills the interface contract by defining what happens when the employee quits.
        public void Quit()
        {
            // This line displays a message showing that the employee has quit the company.
            Console.WriteLine($"{FirstName} {LastName} with employee ID {Id} has quit the company.");
        }
    }

    // This class contains the Main method, which is the entry point of the console application.
    class Program
    {
        // This method runs when the console application starts.
        static void Main(string[] args)
        {
            // This line creates an Employee object and assigns sample values to its properties.
            Employee employee = new Employee { FirstName = "Jane", LastName = "Doe", Id = 7 };

            // This line uses polymorphism by storing the Employee object in a variable typed as the IQuittable interface.
            IQuittable quittableEmployee = employee;

            // This line calls the Quit method through the interface reference.
            quittableEmployee.Quit();

        }
    }
}
