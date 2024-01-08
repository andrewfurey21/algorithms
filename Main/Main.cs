using System;
using Sorting;
namespace Mainline;
public class Mainline {
    public static void Main() {
        int[] arr = {4, 23, 6, 1, 9, 7, 8, 8, 8, 6, 5, 9, 1, 12};
        foreach (int item in arr) {
            Console.Write("{0},", item);
        }
        Console.WriteLine();
        QuickSort.Sort(arr);
        foreach (int item in arr) {
            Console.Write("{0},", item);
        }
        Console.WriteLine();
    }
}
