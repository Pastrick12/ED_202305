using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();

        // Adding elements to the queue
        queue.Enqueue("Apple");
        queue.Enqueue("Banana");
        queue.Enqueue("Orange");

        // Accessing the elements of the queue
        Console.WriteLine("Queue elements:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        // Removing elements from the queue
        string removedItem = queue.Dequeue();
        Console.WriteLine("Removed item: " + removedItem);

        // Checking the front element of the queue
        string frontItem = queue.Peek();
        Console.WriteLine("Front item: " + frontItem);

        // Checking the number of elements in the queue
        int count = queue.Count;
        Console.WriteLine("Number of elements in the queue: " + count);
    }
}