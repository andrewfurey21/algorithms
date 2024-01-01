using System;
using System.Collections;
using Xunit;
using Fundamentals;

namespace FundamentalsTests;
public class BagTests {
    [Fact]
    public static void TestInsertInsert0ReturnTrue() {
        Bag<int> bag = new Bag<int>();

        bag.Insert(0);

        Assert.True(bag.Contains(0), "The bag should contain 0");
    }

    [Fact]
    public static void TestContainsInsertMultipleNumberReturnTrue() {
        Bag<int> bag = new Bag<int>();

        bag.Insert(0);
        bag.Insert(1);
        bag.Insert(2);
        bag.Insert(3);
        bag.Insert(4);
        bag.Insert(5);

        Assert.True(bag.Contains(3), "The bag should contain 0");
    }

    [Fact]
    public static void TestSizeInsert5NumbersReturn5(){

        Bag<int> bag = new Bag<int>();

        bag.Insert(0);
        bag.Insert(1);
        bag.Insert(2);
        bag.Insert(3);
        bag.Insert(4);

        Assert.Equal(bag.Size, 5);
    }

    [Fact]
    public static void TestSizeInsertNoneReturn0() {
        Bag<int> bag = new Bag<int>();
        Assert.Equal(bag.Size, 0);
    }

    [Fact]
    public static void TestIsEmptyInsertNoneReturnTrue() {
       Bag<int> bag = new Bag<int>();
       Assert.True(bag.IsEmpty());
    }

    [Fact]
    public static void TestIsEmptyInsertZeroReturnFalse() {
        Bag<int> bag = new Bag<int>();
        bag.Insert(0);
        Assert.False(bag.IsEmpty());
    }

    [Fact]
    public static void TestInsert20ItemsReturnTrue() {
        Bag<int> bag = new Bag<int>();

        for (int i = 0; i < 20; i++) {
            bag.Insert(i);
        }

        Assert.Equal(bag.Size, 20);
    }
}
