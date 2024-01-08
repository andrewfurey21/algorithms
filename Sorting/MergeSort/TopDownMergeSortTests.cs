using Xunit;
using Sorting;

namespace SortingTests;
public class TopDownMergeSortTests {
    //[Fact]
    //public static void SortArrayLength5() {
    //    int[] expected = {1, 2, 3, 4, 5};
    //    Assert.Equal(expected, TopDownMergeSort.Sort(new int[] {1, 5, 3, 2, 4}));
    //}

    //[Fact]
    //public static void SortArrayLength13() {
    //    int[] expected = {-10, 1, 5, 13, 14, 14, 18, 18, 19, 19, 20, 23, 24};
    //    Assert.Equal(expected, TopDownMergeSort.Sort(new int[] {19, 20, 1, 13, 14, 14, 18, 19, 23, 24, -10, 5, 18}));

    //}

    //[Fact]
    //public static void SortArrayLength0Every0Element() {
    //    int[] expected = {};
    //    Assert.Equal(expected, TopDownMergeSort.Sort(new int[] {}));
    //}

    //[Fact]
    //public static void SortArrayLength0Every1Element() {
    //    int[] expected = {};
    //    Assert.Equal(expected, TopDownMergeSort.Sort(new int[] {}));
    //}

    //[Fact]
    //public static void SortArrayLength10AlreadySorted() {
    //    int[] expected = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    //    Assert.Equal(expected, TopDownMergeSort.Sort(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}));
    //}

    [Fact]
    public static void MergeArrayLength2() {
        int[] expected = {1, 2};
        Assert.Equal(expected, TopDownMergeSort.Merge(new int[]{2, 1}, 0, 0, 1));
    }

    [Fact]
    public static void MergeArrayLength4() {
        int[] expected = {1, 1, 2, 4};
        Assert.Equal(expected, TopDownMergeSort.Merge(new int[]{1, 2, 1, 4}, 0, 1, 3));
    }

    [Fact]
    public static void MergeArrayLength7() {
        int[] expected = {1, 1, 2, 4, 5, 7, 9};
        Assert.Equal(expected, TopDownMergeSort.Merge(new int[]{1, 5, 7, 1, 2, 4, 9}, 0, 2, 6));
    }

    [Fact]
    public static void MergeArrayLength5Start2End4() {
        int[] expected = {1, 2, 1, 2, 3};
        Assert.Equal(expected, TopDownMergeSort.Merge(new int[]{1, 2, 1, 3, 2}, 2, 3, 4));
    }

    [Fact]
    public static void MergeArrayLength10Start1End9() {
        int[] expected = {10, 1, 2, 3, 4, 5, 6, 7, 7, 9};
        Assert.Equal(expected, TopDownMergeSort.Merge(new int[]{10, 1, 9, 2, 3, 4, 5, 6, 7, 7}, 1, 2, 9));
    }
}
