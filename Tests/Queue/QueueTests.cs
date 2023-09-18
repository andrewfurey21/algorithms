using System;
using System.Collections;
using Xunit;
using DataStructures;

namespace Tests;

public class QueueTests {
    [Fact]
    public static void TestEnqueueEnqueueNumberReturnTrue() {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(0);

        Assert.Equal(0, queue.Dequeue());
    }

    [Fact]
    public static void TestMultipleEnqueueReturnTrue() {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(0);
        queue.Enqueue(1);
        queue.Enqueue(2);

        Assert.Equal(0, queue.Dequeue());
    }

    [Fact]
    public static void TestMultipleDequeueReturnTrue() {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(0);
        queue.Enqueue(1);
        queue.Enqueue(2);

        queue.Dequeue();
        queue.Dequeue();

        Assert.Equal(2, queue.Dequeue());
    }

    [Fact]
    public static void TestSizeEnqueue3NumbersReturn3() {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(0);
        queue.Enqueue(0);
        queue.Enqueue(0);

        Assert.Equal(3, queue.Size);
    }

    [Fact]
    public static void TestIsEmptyEnqueueNumberReturnFalse() {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(0);

        Assert.False(queue.IsEmpty());
    }


    [Fact]
    public static void TestIsEmptyReturnTrue() {
        Queue<int> queue = new Queue<int>();
        Assert.True(queue.IsEmpty());
    }

}
