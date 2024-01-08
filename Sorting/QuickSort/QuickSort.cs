namespace Sorting;
public class QuickSort {
    public static int[] Sort(int[] arr) {
        return Sort(arr, 0, arr.Length-1);
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
        int pivotPointer = lowIndex;
        int highPointer = highIndex;
        for (int i = lowIndex + 1; i <= highPointer && highPointer >= pivotPointer; i++) {
            if (arr[pivotPointer] > arr[i]) {
                Swap(arr, pivotPointer, i);
                pivotPointer++;
            } else {
                Swap(arr, i, highPointer);
                highPointer--;
                i--;
            }
        }
        return pivotPointer;
    }

    private static void Swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
