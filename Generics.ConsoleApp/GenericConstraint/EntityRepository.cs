// Reference type constraints --> where T : class
// With this constraint, T can only be a reference type such as a class, an interface, delegate, or array.
// This means T cannot be a value type like int or struct.
// See example how to use this in Program.cs
public class EntityRepository<T> where T : class
{
    private List<T> _entities = new();

    public void Add(T entity)
    {
        if (entity is null)
        {
            Console.WriteLine("Cannot add null entity.");
            return;
        }
        _entities.Add(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }
}