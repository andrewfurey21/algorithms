using System;
using Sorting;
namespace Mainline;
public class Mainline {
    public static void Main() {
        PriorityQueue pq = new PriorityQueue();
        pq.Insert(10);
        pq.Insert(1);
        pq.Insert(9);
        pq.Insert(11);
        pq.Insert(-10);
        pq.Insert(-1);
        pq.Insert(5);
        pq.Insert(23);
        pq.Insert(100);
        pq.Insert(45);

        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
        Console.WriteLine(pq.Pop());
    }
}
