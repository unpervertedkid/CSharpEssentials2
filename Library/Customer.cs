﻿namespace Generics;

public class Customer
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
    
}