// 5 Type of Constraints in C# Generics
// 1. Interface Constraints --> where T : IComparable<T>
// 2. Class Constraints --> where T : Product
// 3. Reference type Constraints --> where T : class
// 4. Value type Constraints --> where T : struct
// 5. Constructor Constraints --> where T : new()
public class Utilities<T> where T : IComparable<T>
{
    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    public static T Max(T a, T b)
    {
        // Without the constraint, we cannot use CompareTo
        // This will throw an error if T does not implement IComparable<T>
        return a.CompareTo(b) > 0 ? a : b;
    }
}