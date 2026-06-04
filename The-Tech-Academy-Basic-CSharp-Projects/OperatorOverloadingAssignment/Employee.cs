// Imports the System namespace so the program can use Console methods and basic object functionality.
using System;

// Defines a namespace to organize the Employee class inside the project.
namespace OperatorOverloadingAssignment
{
    // Declares the Employee class, which represents an employee and its identifying information.
    public class Employee
    {
        // Defines a property to store the employee's unique identifier.
        public int Id { get; set; }

        // Defines a property to store the employee's first name.
        public string FirstName { get; set; }

        // Defines a property to store the employee's last name.
        public string LastName { get; set; }

        // Overloads the equality operator so two Employee objects are compared by their Id values.
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Checks whether both employee references are null.
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                // Returns true because two null references are considered equal.
                return true;
            }

            // Checks whether only one of the employee references is null.
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
            {
                // Returns false because a null reference cannot equal a non-null reference.
                return false;
            }

            // Returns true when both Employee objects have the same Id value.
            return employee1.Id == employee2.Id;
        }

        // Overloads the inequality operator so it returns the opposite of the equality operator.
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // Returns true when the Employee objects do not have the same Id value.
            return !(employee1 == employee2);
        }

        // Overrides the Equals method so object equality follows the same rule as the overloaded == operator.
        public override bool Equals(object obj)
        {
            // Attempts to convert the supplied object into an Employee object.
            Employee employee = obj as Employee;

            // Returns false if the supplied object is not an Employee.
            if (employee == null)
            {
                // Ends the method because the objects cannot be equal if the types do not match.
                return false;
            }

            // Returns true if this Employee object's Id matches the other Employee object's Id.
            return this.Id == employee.Id;
        }

        // Overrides GetHashCode so it stays consistent with the equality logic based on Id.
        public override int GetHashCode()
        {
            // Returns a hash code generated from the Id property.
            return Id.GetHashCode();
        }
    }
}
