using System;

// This namespace keeps the Employee class with the rest of the assignment types.
namespace PolymorphismAssignment
{
    // This class represents an employee and implements the IQuittable interface.
    public class Employee : IQuittable
    {
        // This property stores the employee's first name.
        public string FirstName { get; set; }

        // This property stores the employee's last name.
        public string LastName { get; set; }

        // This property stores the employee's ID number.
        public int Id { get; set; }

        // This constructor initializes a new Employee with basic identity values.
        public Employee(string firstName, string lastName, int id)
        {
            // This sets the FirstName property from the constructor input.
            FirstName = firstName;

            // This sets the LastName property from the constructor input.
            LastName = lastName;

            // This sets the Id property from the constructor input.
            Id = id;
        }

        // This method provides the required interface implementation for quit behavior.
        public void Quit()
        {
            // This displays a simple message confirming the employee's quit action.
            Console.WriteLine($"Employee {Id}: {FirstName} {LastName} has quit the company.");
        }
    }
}
