namespace Sorting;
public class HeapSort {
    public static int[] Sort(int[] arr) {
        for (int i = arr.Length/2 - 1; i >= 0; i--) {
            Sink(arr, i, arr.Length);
        }

        for (int i = arr.Length - 1; i > 0; i--) {
            Swap(arr, 0, i);
            Sink(arr, 0, i);
        }

        return arr;
    }

    public static void Sink(int[] arr, int index, int heapSize) {
        int current = index;
        while (current < heapSize) {
            int child = current*2+1;
            if (child < heapSize - 1 && arr[child] < arr[child+1]) {
                child++;
            }

            if (child < heapSize && arr[current] < arr[child]) {
                Swap(arr, current, child);
                current = child;
            } else break;
        }
    }

    private static void Swap(int[] arr, int firstIndex, int secondIndex) {
        int temp = arr[firstIndex];
        arr[firstIndex] = arr[secondIndex];
        arr[secondIndex] = temp;
    }
}
