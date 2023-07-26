using System;


public class Mainline {
    public static void Main() {
        Bag<int> bag = new Bag<int>();
        bag.Insert(10);
        if (bag.Contains(10)) {
            Console.WriteLine("Bag contains 10");
        }
    }
}
