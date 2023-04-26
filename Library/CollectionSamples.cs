namespace Library;

public class CollectionSamples
{
    private static readonly List<Customer> Customers;
    static CollectionSamples()
    {
        Customers = new List<Customer>();

        for (int i = 0; i < 11; i++)
        {
            Customers.Add(
                new Customer()
                {
                    Id = i,
                    FirstName = $"First Name {i}",
                    LastName = $"Last Name {i}",
                    Age = i * 10,
                    Address = $"Address {i}"
                }
            );
        }
    }
    
    public static void StackExample()
    {
        var stack = new Stack<string>();

        stack.Push("First item");
        stack.Push("Second item");

        while (stack.Pop() is { } stackItem)
        {
            Console.WriteLine(stackItem);
            if (stack.Count <= 0)
            {
                break;
            }
        }
        
    }
    
    public static void QueueExample()
    {
        var queue = new Queue<string>();

        queue.Enqueue("First item");
        queue.Enqueue("Second item");

        while (queue.Dequeue() is { } queueItem)
        {
            Console.WriteLine(queueItem);
            if (queue.Count <= 0)
            {
                break;
            }
        }
    }

    public static void Indexing()
    {
        //Getting an item at a specific index
        var customer = Customers[0];
        Console.WriteLine(customer.FirstName);
        
        //Check if a collection contains an item
        Console.WriteLine(Customers.Contains(customer));
        
       //Use a predicate to find an item in the collection
       var customerSeven = Customers.Find(c => c.Id == 7);

       Console.WriteLine(customerSeven != null ? customerSeven.FirstName : "Customer not found");
    }

    public static void Iterating()
    {
        //Reverse the collection
        Customers.Reverse();
        
        //Using for loop
        for (int i = 0; i < Customers.Count; i++)
        {
            Console.WriteLine(Customers[i].FirstName);
        }
        
        IEnumerator<Customer> customerEnumerator = Customers.GetEnumerator();
        while (customerEnumerator.MoveNext())
        {
            Customer current = customerEnumerator.Current;
            Console.WriteLine(current.FirstName);
        }
        
        customerEnumerator.Dispose();
        
        //Sort the customers
        Customers.Sort();
        
        //Using foreach
        foreach (var customer in Customers)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
    
}