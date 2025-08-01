// Create ObjectList class can reduce code duplication but we have to deal with performance issues
// When add object to the list, it will box the value type
// and unbox it when retrieving, which can be less efficient than using a strongly typed list

public class ObjectList
{
    public void Add(object item)
    {
        throw new NotImplementedException("Add method is not implemented yet.");
    }

    public object this[int index]
    {
        get
        {
            throw new NotImplementedException("Indexer is not implemented yet.");
        }
    }
}