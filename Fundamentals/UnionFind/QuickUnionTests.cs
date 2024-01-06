using Xunit;
using Fundamentals;

namespace FundamentalsTests;
public class QuickUnionTests{
    [Fact]
    public static void TestUnionLength10Return5Components() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(0, 1);
        qu.Union(2, 3);
        qu.Union(4, 5);
        qu.Union(6, 7);
        qu.Union(8, 9);

        Assert.Equal(5, qu.Count());
    }

    [Fact]
    public static void TestUnionLength10Return1Components() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(0, 1);
        qu.Union(2, 3);
        qu.Union(4, 5);
        qu.Union(6, 7);
        qu.Union(8, 9);
        qu.Union(9, 1);
        qu.Union(7, 9);
        qu.Union(1, 2);
        qu.Union(5, 7);

        Assert.Equal(1, qu.Count());
    }

    [Fact]
    public static void TestUnionLength10Return10Components() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(0, 0);
        qu.Union(1, 1);
        qu.Union(2, 2);
        qu.Union(3, 3);
        qu.Union(4, 4);
        qu.Union(5, 5);
        qu.Union(6, 6);
        qu.Union(7, 7);
        qu.Union(8, 8);
        qu.Union(9, 9);

        Assert.Equal(10, qu.Count());
    }

    [Fact]
    public static void TestConnectedLength10ReturnTrue() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(1, 2);
        Assert.True(qu.Connected(1, 2), "1 should be connected to 2.");
    }

    [Fact]
    public static void TestConnectedLength10ReturnFalse() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(1, 2);
        qu.Union(2, 4);
        qu.Union(5, 3);
        Assert.False(qu.Connected(4, 3), "4 should not be connected to 3");
    }

    [Fact]
    public static void TestConnectedLength5ReturnTrue() {
        QuickUnion qu = new QuickUnion(5);
        qu.Union(1, 2);
        qu.Union(2, 4);
        qu.Union(4, 3);
        qu.Union(0, 1);
        Assert.True(qu.Connected(0, 4), "0 should be connected to 4.");
    }


    [Fact]
    public static void TestFindLength10Return1() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(1, 2);
        Assert.Equal(1, qu.Find(2));
    }

    [Fact]
    public static void TestFindLength10Return0() {
        QuickUnion qu = new QuickUnion(10);
        qu.Union(1, 2);
        qu.Union(2, 4);
        qu.Union(5, 3);
        Assert.True(qu.Connected(0, 0), "0's root should be 0");
    }

    [Fact]
    public static void TestFindLength5Return1() {
        QuickUnion qu = new QuickUnion(5);
        qu.Union(1, 2);
        qu.Union(2, 4);
        qu.Union(4, 3);
        qu.Union(0, 1);
        Assert.Equal(0, qu.Find(4));
    }

}
