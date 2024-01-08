using Xunit;
using Sorting;

namespace SortingTests;
public class QuickSortTests {

    [Fact]
    public static void SortArrayLength5() {
        int[] expected = {1, 2, 3, 4, 5};
        Assert.Equal(expected, QuickSort.Sort(new int[] {1, 5, 3, 2, 4}));
    }

    [Fact]
    public static void SortArrayLength13() {
        int[] expected = {-10, 1, 5, 13, 14, 14, 18, 18, 19, 19, 20, 23, 24};
        Assert.Equal(expected, QuickSort.Sort(new int[] {19, 20, 1, 13, 14, 14, 18, 19, 23, 24, -10, 5, 18}));

    }

    [Fact]
    public static void SortArray() {
        int[] expected = {1, 1, 4, 5, 6, 6, 7, 8, 8, 8, 9, 9, 12, 23};
        Assert.Equal(expected, QuickSort.Sort(new int[] {4, 23, 6, 1, 9, 7, 8, 8, 8, 6, 5, 9, 1, 12}));
    }

    [Fact]
    public static void SortArrayLength0Every0Element() {
        int[] expected = {};
        Assert.Equal(expected, QuickSort.Sort(new int[] {}));
    }


    [Fact]
    public static void SortArrayLength10AlreadySorted() {
        int[] expected = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
        Assert.Equal(expected, QuickSort.Sort(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}));
    }

}
