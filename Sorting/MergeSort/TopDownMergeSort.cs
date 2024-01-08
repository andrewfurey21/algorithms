namespace Sorting;
public class TopDownMergeSort {
    public static int[] Sort(int[] arr) {
        return Sort(arr, 0, arr.Length-1);
    }

    public static int[] Sort(int[] arr, int lowIndex, int highIndex) {
        if (highIndex <= lowIndex) {
            return arr;
        }
        int midIndex = lowIndex + (highIndex - lowIndex) / 2;//3, 5
        Sort(arr, lowIndex, midIndex);
        Sort(arr, midIndex+1, highIndex);
        Merge(arr, lowIndex, midIndex, highIndex);
        return arr;
    }

    public static int[] Merge(int[] arr, int lowIndex, int midIndex, int highIndex) {
        int lowPointer = 0;
        int highPointer = (midIndex + 1)-lowIndex;

        int[] arrCopy = new int[highIndex-lowIndex+1];
        for (int i = 0; i < arrCopy.Length; i++) {
            arrCopy[i] = arr[i+lowIndex];
        }

        for (int i = lowIndex; i <= highIndex; i++) {
            if (lowPointer > (midIndex-lowIndex)) {
                arr[i] = arrCopy[highPointer];
                highPointer++;
            } else if (highPointer >= arrCopy.Length) {
                arr[i] = arrCopy[lowPointer];
                lowPointer++;
            } else if (arrCopy[lowPointer] < arrCopy[highPointer]) {
                arr[i] = arrCopy[lowPointer];
                lowPointer++;
            } else {
                arr[i] = arrCopy[highPointer];
                highPointer++;
            }

        }
        return arr;
    }
}
