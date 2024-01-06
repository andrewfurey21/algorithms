using Xunit;
using Sorting;

namespace SortingTests;
public class ShellShortTests {
    [Fact]
    public static void SortArrayLength5() {
        int[] expected = {1, 2, 3, 4, 5};
        Assert.Equal(expected, ShellSort.Sort(new int[] {1, 5, 3, 2, 4}, 2, 1));
    }

    [Fact]
    public static void SortArrayLength13() {
        int[] expected = {-10, 1, 5, 13, 14, 14, 18, 18, 19, 19, 20, 23, 24};
        Assert.Equal(expected, ShellSort.Sort(new int[] {19, 20, 1, 13, 14, 14, 18, 19, 23, 24, -10, 5, 18}, 3, 1));

    }

    [Fact]
    public static void SortArrayLength13ab() {
        int[] expected = {                              -10, 5, 1, 13, 14, 14, 18, 19, 18, 20, 19, 24, 23};
        Assert.Equal(expected, ShellSort.Sort(new int[] {19, 20, 1, 13, 14, 14, 18, 19, 23, 24, -10, 5, 18}, 2, 2));
    }

    [Fact]
    public static void SortArrayLength0Every0Element() {
        int[] expected = {};
        Assert.Equal(expected, ShellSort.Sort(new int[] {}, 0, 1));
    }

    [Fact]
    public static void SortArrayLength0Every1Element() {
        int[] expected = {};
        Assert.Equal(expected, ShellSort.Sort(new int[] {}, 1, 1));
    }

    [Fact]
    public static void SortArrayLength10AlreadySorted() {
        int[] expected = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Assert.Equal(expected, ShellSort.Sort(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 1, 1));
    }
}
