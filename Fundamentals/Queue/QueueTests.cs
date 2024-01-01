using Xunit;
using Fundamentals;

namespace FundamentalsTests;
public class QueueTests {
    [Fact]
    public static void TestEnqueueEnqueueNumberReturnTrue() {
        Fundamentals.Queue<int> queue = new Fundamentals.Queue<int>();

        queue.Enqueue(0);

        Assert.Equal(0, queue.Dequeue());
    }

    [Fact]
    public static void TestMultipleEnqueueReturnTrue() {
        Fundamentals.Queue<int> queue = new Fundamentals.Queue<int>();

        queue.Enqueue(0);
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.Equal(0, queue.Dequeue());
    }

    [Fact]
    public static void TestMultipleDequeueReturnTrue() {
        Fundamentals.Queue<int> queue = new Fundamentals.Queue<int>();

        queue.Enqueue(0);
        queue.Enqueue(1);
        queue.Enqueue(2);

        queue.Dequeue();
        queue.Dequeue();

        Assert.Equal(2, queue.Dequeue());
    }

    [Fact]
    public static void TestSizeEnqueue3NumbersReturn3() {
        Fundamentals.Queue<int> queue = new Fundamentals.Queue<int>();

        queue.Enqueue(0);
        queue.Enqueue(0);
        queue.Enqueue(0);

        Assert.Equal(3, queue.Size);
    }

    [Fact]
    public static void TestIsEmptyEnqueueNumberReturnFalse() {
        Fundamentals.Queue<int> queue = new Fundamentals.Queue<int>();

        queue.Enqueue(0);

        Assert.False(queue.IsEmpty());
    }


    [Fact]
    public static void TestIsEmptyReturnTrue() {
        Fundamentals.Queue<int> queue = new Fundamentals.Queue<int>();
        Assert.True(queue.IsEmpty());
    }

}
