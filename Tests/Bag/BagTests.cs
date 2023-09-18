using System;
using System.Collections;
using Xunit;
using DataStructures;

namespace DataStructures.Test;

public class BagTests {
    [Fact]
    public static void TestInsert() {
        Bag<int> bag = new Bag<int>();

        bag.Insert(0);

        Assert.True(bag.Contains(0), "The bag should contain 0");
    }
}
