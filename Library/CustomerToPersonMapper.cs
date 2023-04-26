namespace Library;

public class CustomerToPersonMapper: IMapper<Customer,Person>
{
    public Person Map(Customer source)
    {
        return new Person(source.FirstName, source.LastName, source.Age);
    }
}