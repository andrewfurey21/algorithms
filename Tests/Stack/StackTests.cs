using Xunit;
using DataStructures;

namespace Tests;
public class StackTests {
    [Fact]
    public static void TestIsEmptyReturnTrue() {
        StackArray<int> stack = new StackArray<int>();
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public static void TestIsEmptyReturnFalse() {
        StackArray<int> stack = new StackArray<int>();
        stack.Push(5);
        Assert.False(stack.IsEmpty());
    }

    [Fact]
    public static void TestPopInsertNumberReturnNumber() {
        StackArray<int> stack = new StackArray<int>();
        stack.Push(0);
        Assert.Equal(stack.Pop(), 0);
    }

    [Fact]
    public static void TestPopMultipleInsertReturnFirstNumber() {
        StackArray<int> stack = new StackArray<int>();
        stack.Push(0);
        stack.Push(1);
        stack.Push(2);

        Assert.Equal(stack.Pop(), 2);
    }

    [Fact]
    public static void TestPush20PushReturnLastNumber() {

        StackArray<int> stack = new StackArray<int>();

        for (int i = 0; i < 20; i++) {
            stack.Push(i);
        }
        Assert.Equal(stack.Pop(), 19);
    }
}
