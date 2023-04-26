namespace Library;

public class CollectionSamples
{
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
}