using Generics;
using Library;

var c = new Customer()
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    Age = 30,
    Address = "123 Main St"
};

var c2 = new Customer()
{
    Id = 2,
    FirstName = "Petter",
    LastName = "Griffin",
    Age = 25,
    Address = "123 Main St"
};

var mapper = new CustomerToPersonMapper();
var p = c.Map<Person>(mapper); //mapper.Map(c));

Console.WriteLine($"First Name: {p.FirstName}");

var sorter = new Sorter<Customer>();
var customers = new Customer[] { c2, c };
sorter.Sort(customers);

foreach (var customer in customers)
{
    Console.WriteLine($"Customer {customer.Id} : {customer.LastName}");
}


