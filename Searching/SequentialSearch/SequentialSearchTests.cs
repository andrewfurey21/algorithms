using Xunit;
using Searching;

namespace SearchingTests;
public class SequentialSearchTests {
    [Fact]
    public static void TestPutGet() {
        SequentialSearch<int, int> ss = new SequentialSearch<int, int>();

        ss.Put(5, 4);
        ss.Put(3, 3);
        ss.Put(1, 9);

        Assert.Equal(4, ss.Get(5));
        Assert.Equal(9, ss.Get(1));
        Assert.Equal(3, ss.Get(3));
    }

    [Fact]
    public static void TestPutGetThrowsException() {
        SequentialSearch<int, int> ss = new SequentialSearch<int, int>();

        ss.Put(5, 4);
        ss.Put(3, 3);
        ss.Put(1, 9);

        Assert.Throws<Exception>(() => ss.Get(10));
    }

    [Fact]
    public static void TestContains() {
        SequentialSearch<int, int> ss = new SequentialSearch<int, int>();

        ss.Put(5, 4);
        ss.Put(3, 3);
        ss.Put(1, 9);

        ss.Put(2, 4);
        ss.Put(4, 3);
        ss.Put(6, 9);
        ss.Put(7, 4);
        ss.Put(8, 3);
        ss.Put(9, 9);
        ss.Put(10, 4);
        ss.Put(13, 3);
        ss.Put(11, 9);

        Assert.True(ss.Contains(10));
    }

    [Fact]
    public static void TestContainsDoesNotContain() {
        SequentialSearch<int, int> ss = new SequentialSearch<int, int>();

        ss.Put(5, 4);
        ss.Put(3, 3);
        ss.Put(1, 9);

        ss.Put(2, 4);
        ss.Put(4, 3);
        ss.Put(6, 9);
        ss.Put(7, 4);
        ss.Put(8, 3);
        ss.Put(9, 9);
        ss.Put(10, 4);
        ss.Put(13, 3);
        ss.Put(11, 9);

        Assert.False(ss.Contains(19));
    }
}
