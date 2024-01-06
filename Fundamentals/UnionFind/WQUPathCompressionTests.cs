using Xunit;
using Fundamentals;

namespace FundamentalsTests;
public class WQUPathCompressionTest {
    [Fact]
    public static void TestUnionLength10Return5Components() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(0, 1);
        wqu.Union(2, 3);
        wqu.Union(4, 5);
        wqu.Union(6, 7);
        wqu.Union(8, 9);
        Assert.Equal(5, wqu.Count());
    }

    [Fact]
    public static void TestUnionLength10Return1Components() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(0, 1);
        wqu.Union(2, 3);
        wqu.Union(4, 5);
        wqu.Union(6, 7);
        wqu.Union(8, 9);
        wqu.Union(9, 1);
        wqu.Union(7, 9);
        wqu.Union(1, 2);
        wqu.Union(5, 7);

        Assert.Equal(1, wqu.Count());
    }

    [Fact]
    public static void TestUnionLength10Return10Components() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(0, 0);
        wqu.Union(1, 1);
        wqu.Union(2, 2);
        wqu.Union(3, 3);
        wqu.Union(4, 4);
        wqu.Union(5, 5);
        wqu.Union(6, 6);
        wqu.Union(7, 7);
        wqu.Union(8, 8);
        wqu.Union(9, 9);

        Assert.Equal(10, wqu.Count());
    }

    [Fact]
    public static void TestConnectedLength10ReturnTrue() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(1, 2);
        Assert.True(wqu.Connected(1, 2), "1 should be connected to 2.");
    }

    [Fact]
    public static void TestConnectedLength10ReturnFalse() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(1, 2);
        wqu.Union(2, 4);
        wqu.Union(5, 3);
        Assert.False(wqu.Connected(4, 3), "4 should not be connected to 3");
    }

    [Fact]
    public static void TestConnectedLength5ReturnTrue() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(5);
        wqu.Union(1, 2);
        wqu.Union(2, 3);
        wqu.Union(4, 3);
        wqu.Union(0, 1);
        Assert.True(wqu.Connected(0, 4), "0 should be connected to 4.");
    }


    [Fact]
    public static void TestFindLength10Return1() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(1, 2);
        Assert.Equal(1, wqu.Find(2));
    }

    [Fact]
    public static void TestFindLength10Return0() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(10);
        wqu.Union(1, 2);
        wqu.Union(2, 4);
        wqu.Union(5, 3);
        Assert.True(wqu.Connected(0, 0), "0's root should be 0");
    }

    [Fact]
    public static void TestFindLength5Return1() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(5);
        wqu.Union(1, 2);
        wqu.Union(2, 4);
        wqu.Union(4, 3);
        wqu.Union(0, 1);
        Assert.Equal(1, wqu.Find(4));
    }

    [Fact]
    public static void TestFindLength5Return2() {
        WeightedQuickUnionPathCompression wqu = new WeightedQuickUnionPathCompression(5);
        wqu.Union(0, 1);
        wqu.Union(2, 3);
        wqu.Union(2, 4);
        wqu.Union(2, 1);


        Assert.Equal(2, wqu.Find(0));
    }
}
