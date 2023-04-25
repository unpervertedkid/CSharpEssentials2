namespace Generics;

public class Person
{
    public Person(string firstName, string lastName, string age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
}