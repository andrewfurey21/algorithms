using Xunit;
using Sorting;

namespace SortingTests;
public class PriorityQueueTests {
    [Fact]
    public static void TestPriorityQueue() {
        PriorityQueue pq = new PriorityQueue();
        pq.Insert(10);
        pq.Insert(1);
        pq.Insert(9);
        pq.Insert(11);

        Assert.Equal(1, pq.Pop());
        Assert.Equal(9, pq.Pop());
        Assert.Equal(10, pq.Pop());
        Assert.Equal(11, pq.Pop());
    }

    [Fact]
    public static void TestPriorityQueueThrowException() {
        PriorityQueue pq = new PriorityQueue();

        Assert.Throws<InvalidOperationException>(() => pq.Pop());
    }

    [Fact]
    public static void TestPriorityQueueInsertSameNumber() {
        PriorityQueue pq = new PriorityQueue();
        pq.Insert(10);
        pq.Insert(10);
        pq.Insert(10);
        pq.Insert(10);

        Assert.Equal(10, pq.Pop());
        Assert.Equal(10, pq.Pop());
        Assert.Equal(10, pq.Pop());
        Assert.Equal(10, pq.Pop());
    }

    [Fact]
    public static void TestPriorityQueueInsert10Ints() {
        PriorityQueue pq = new PriorityQueue();
        pq.Insert(10);
        pq.Insert(1);
        pq.Insert(9);
        pq.Insert(11);
        pq.Insert(-10);
        pq.Insert(-1);
        pq.Insert(5);
        pq.Insert(23);
        pq.Insert(100);
        pq.Insert(45);

        Assert.Equal(-10, pq.Pop());
        Assert.Equal(-1, pq.Pop());
        Assert.Equal(1, pq.Pop());
        Assert.Equal(5, pq.Pop());
        Assert.Equal(9, pq.Pop());
        Assert.Equal(10, pq.Pop());
        Assert.Equal(11, pq.Pop());
        Assert.Equal(23, pq.Pop());
        Assert.Equal(45, pq.Pop());
        Assert.Equal(100, pq.Pop());
    }
}
