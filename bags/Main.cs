using System;


public class Mainline {
    public static void Main() {
        Bag<int> bag = new Bag<int>();
        bag.Insert(10);
        if (bag.Contains(10)) {
            Console.WriteLine("Bag contains 10");
        }
        for (int i = 0; i < 10; i++) {
            bag.Insert(i*3);
        }
        foreach (var item in bag) {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Bag size: {bag.Size}");
    }
}
