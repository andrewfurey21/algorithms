using System;
using System.Diagnostics;

public class Mainline {
    public static void Main() {
        Queue<int> q = new Queue<int>();
        for (int i = 0; i < 1000; i++) {
            q.Enqueue(i);
        }
        for (int i = 0; i < 1000; i++) {
            Debug.Assert(q.Dequeue() == i);
        }

        //TODO: fix
        int a = q.Dequeue();
        q.Dequeue();
        q.Dequeue();
        Console.WriteLine(a);
    }
}
