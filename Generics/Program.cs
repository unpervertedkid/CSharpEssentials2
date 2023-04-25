using Generics;

var c = new Customer()
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    Age = 30,
    Address = "123 Main St"
};


var mapper = new CustomerToPersonMapper();
var p = c.Map<Person>(mapper); //mapper.Map(c));

Console.WriteLine($"First Name: {p.FirstName}");
