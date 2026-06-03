// This namespace keeps the interface with the rest of the assignment types.
namespace PolymorphismAssignment
{
    // This interface defines behavior for objects that can perform a quit action.
    public interface IQuittable
    {
        // This method signature requires implementing classes to define quit behavior.
        void Quit();
    }
}
