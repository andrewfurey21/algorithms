using Xunit;

using LinkedList = DataStructures.LinkedList<int>;

namespace Tests;
public class LinkedListTests {
    [Fact]
    public static void TestSizeReturnSize0() {
        LinkedList list = new LinkedList();

        Assert.Equal(list.Size, 0);
    }

    [Fact]
    public static void TestPopPushNothingReturnDefault() {
        LinkedList list = new LinkedList();

        Assert.Equal(list.Pop(), default(int));
    }

    [Fact]
    public static void TestPushPushZeroReturnSize1() {
        LinkedList list = new LinkedList();

        list.Push(0);

        Assert.Equal(list.Size, 1);
    }

    [Fact]
    public static void TestPushPush10NumbersReturnSize10() {
        LinkedList list = new LinkedList();

        for (int i = 0; i < 10; i++) {
            list.Push(i);
        }

        Assert.Equal(list.Size, 10);
    }

    [Fact]
    public static void TestPopPushOneNumberReturnNumber() {
        LinkedList list = new LinkedList();

        list.Push(0);

        Assert.Equal(list.Pop(), 0);
    }

    [Fact]
    public static void TestPopPushTenNumbersReturnLastNumber() {
        LinkedList list = new LinkedList();

        for (int i = 0; i < 10; i++) {
            list.Push(i);
        }

        Assert.Equal(9, list.Pop());
    }


    [Fact]
    public static void TestGetPushTenNumbersReturnFirstNumber() {
        LinkedList list = new LinkedList();

        for (int i = 0; i < 10; i++) {
            list.Push(i);
        }

        Assert.Equal(0, list.Get(0));
    }


    [Fact]
    public static void TestGetPushTenNumbersReturnLastNumber() {
        LinkedList list = new LinkedList();

        for (int i = 0; i < 10; i++) {
            list.Push(i);
        }

        Assert.Equal(list.Get(9), 9);
    }

    [Fact]
    public static void TestGetPushNothingReturnDefault() {
        LinkedList list = new LinkedList();

        Assert.Equal(list.Get(9), default(int));
    }
}
