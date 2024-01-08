namespace Sorting;
public class TopDownMergeSort {
    public static int[] Sort(int[] arr) {
        return Sort(arr, 0, arr.Length);
    }

    public static int[] Sort(int[] arr, int lowIndex, int highIndex) {
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
            if (lowPointer > midIndex) {//0>0?no
                arr[i] = arrCopy[highPointer];
                highPointer++;
            } else if (highPointer >= arrCopy.Length) {//1>1?no
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


   //public static void Swap(int[] arr, int first, int second) {
   //     int temp = arr[first];
   //     arr[first] = arr[second];
   //     arr[second] = temp;
   // }
}
