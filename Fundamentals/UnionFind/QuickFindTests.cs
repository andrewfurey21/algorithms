using Xunit;
using Fundamentals;

namespace FundamentalsTests;
public class QuickFindTests {
    [Fact]
    public static void TestUnionLength10Return5Components() {
        QuickFind qf = new QuickFind(10);
        qf.Union(0, 1);
        qf.Union(2, 3);
        qf.Union(4, 5);
        qf.Union(6, 7);
        qf.Union(8, 9);

        Assert.Equal(5, qf.Count());
    }

    [Fact]
    public static void TestUnionLength10Return1Components() {
        QuickFind qf = new QuickFind(10);
        qf.Union(0, 1);
        qf.Union(2, 3);
        qf.Union(4, 5);
        qf.Union(6, 7);
        qf.Union(8, 9);
        qf.Union(9, 1);
        qf.Union(7, 9);
        qf.Union(1, 2);
        qf.Union(5, 7);

        Assert.Equal(1, qf.Count());
    }

    [Fact]
    public static void TestUnionLength10Return10Components() {
        QuickFind qf = new QuickFind(10);
        qf.Union(0, 0);
        qf.Union(1, 1);
        qf.Union(2, 2);
        qf.Union(3, 3);
        qf.Union(4, 4);
        qf.Union(5, 5);
        qf.Union(6, 6);
        qf.Union(7, 7);
        qf.Union(8, 8);
        qf.Union(9, 9);

        Assert.Equal(10, qf.Count());
    }

    [Fact]
    public static void TestConnectedLength10ReturnTrue() {
        QuickFind qf = new QuickFind(10);
        qf.Union(1, 2);
        Assert.True(qf.Connected(1, 2), "1 should be connected to 2.");
    }

    [Fact]
    public static void TestConnectedLength10ReturnFalse() {
        QuickFind qf = new QuickFind(10);
        qf.Union(1, 2);
        qf.Union(2, 4);
        qf.Union(5, 3);
        Assert.False(qf.Connected(4, 3), "4 should not be connected to 3");
    }

    [Fact]
    public static void TestConnectedLength5ReturnTrue() {
        QuickFind qf = new QuickFind(5);
        qf.Union(1, 2);
        qf.Union(2, 4);
        qf.Union(4, 3);
        qf.Union(0, 1);
        Assert.True(qf.Connected(0, 4), "0 should be connected to 4.");
    }


    [Fact]
    public static void TestFindLength10Return1() {
        QuickFind qf = new QuickFind(10);
        qf.Union(1, 2);
        Assert.Equal(1, qf.Find(2));
    }

    [Fact]
    public static void TestFindLength10Return0() {
        QuickFind qf = new QuickFind(10);
        qf.Union(1, 2);
        qf.Union(2, 4);
        qf.Union(5, 3);
        Assert.True(qf.Connected(0, 0), "0's root should be 0");
    }

    [Fact]
    public static void TestFindLength5Return1() {
        QuickFind qf = new QuickFind(5);
        qf.Union(1, 2);
        qf.Union(2, 4);
        qf.Union(4, 3);
        qf.Union(0, 1);
        Assert.Equal(0, qf.Find(4));
    }

}
