namespace Sorting;
public class QuickSort {
    public static int[] Sort(int[] arr) {
        return arr;
    }

    public static int[] Sort(int[] arr, int lowIndex, int highIndex) {
        if (lowIndex >= highIndex) {
            return arr;
        }
        int pivot = Partition(arr, lowIndex, highIndex);
        Sort(arr, lowIndex, pivot-1);
        Sort(arr, pivot+1, highIndex);
        return arr;
    }

    public static int Partition(int[] arr, int lowIndex, int highIndex) {
        return 0;
    }
}
