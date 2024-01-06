using Xunit;
using Fundamentals;

namespace FundamentalsTests;
public class StackTests {
    [Fact]
    public static void TestIsEmptyReturnTrue() {
        Fundamentals.Stack<int> stack = new Fundamentals.Stack<int>();
        Assert.True(stack.IsEmpty());
    }

    [Fact]
    public static void TestIsEmptyReturnFalse() {
        Fundamentals.Stack<int> stack = new Fundamentals.Stack<int>();
        stack.Push(5);
        Assert.False(stack.IsEmpty());
    }

    [Fact]
    public static void TestPopInsertNumberReturnNumber() {
        Fundamentals.Stack<int> stack = new Fundamentals.Stack<int>();
        stack.Push(0);
        Assert.Equal(0, stack.Pop());
    }

    [Fact]
    public static void TestPopMultipleInsertReturnFirstNumber() {
        Fundamentals.Stack<int> stack = new Fundamentals.Stack<int>();
        stack.Push(0);
        stack.Push(1);
        stack.Push(2);

        Assert.Equal(2, stack.Pop());
    }

    [Fact]
    public static void TestPush20PushReturnLastNumber() {
        Fundamentals.Stack<int> stack = new Fundamentals.Stack<int>();

        for (int i = 0; i < 20; i++) {
            stack.Push(i);
        }
        Assert.Equal(19, stack.Pop());
    }
}
