namespace Sorting;
public class ShellSort {
    public static int[] Sort(int[] arr, int h) {
        for (int k = h; k >= 1; k-=1) {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i; j >= 0; j--) {
                    if (j+k < arr.Length && arr[j+k] < arr[j]) {
                        int temp = arr[j+k];
                        arr[j+k] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }
        return arr;
    }
}
