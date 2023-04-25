namespace Generics;

public class Customer: IComparable<Customer>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    
    public T Map<T>(IMapper<Customer,T> mapper)
    {
        return mapper.Map(this);
    }

    public int CompareTo(Customer? other)
    {
        if (other.Id > Id)
        {
            return -1;
        }
        else if (other.Id < Id)
        {
            return 1;
        }
        return 0;
    }
}