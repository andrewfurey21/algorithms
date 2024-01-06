namespace Sorting;
public class InsertionSort {
    public static int[] Sort(int[] arr) {
        for (int i = 0; i < arr.Length; i++) {
            for (int j = i - 1; j >= 0; j--) {
                if (arr[j] > arr[j+1]) {
                    int temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        return arr;
    }
}
