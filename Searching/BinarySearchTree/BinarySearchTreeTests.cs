using Xunit;
using Searching;

namespace SearchingTests;
public class BinarySearchTreeTests {
    [Fact]
    public static void TestPut() {
        BinarySearchTree<int, int> bst = new BinarySearchTree<int, int>();

        bst.Put(1, 1);
        bst.Put(10, 10);
        bst.Put(2, 2);
        bst.Put(-2, 1);

        Assert.Equal("(1, 1), (-2, 1), (null), (null), (10, 10), (2, 2), (null), (null), (null)", bst.ToString());
    }

    [Fact]
    public static void TestPutNoPuts() {
        BinarySearchTree<int, int> bst = new BinarySearchTree<int, int>();

        Assert.Equal("(null)", bst.ToString());
    }

    [Fact]
    public static void TestPutReplaceOneVal() {
        BinarySearchTree<int, int> bst = new BinarySearchTree<int, int>();

        bst.Put(1, 1);
        bst.Put(10, 10);
        bst.Put(2, 2);
        bst.Put(-2, 1);
        bst.Put(10, 9);

        Assert.Equal("(1, 1), (-2, 1), (null), (null), (10, 9), (2, 2), (null), (null), (null)", bst.ToString());
    }

    [Fact]
    public static void TestGet() {
        BinarySearchTree<int, int> bst = new BinarySearchTree<int, int>();

        bst.Put(1, 1);
        bst.Put(10, 10);
        bst.Put(2, 2);
        bst.Put(-2, 1);

        Assert.Equal(2, bst.Get(2));
    }

    [Fact]
    public static void TestGetNoPuts() {
        BinarySearchTree<int, int> bst = new BinarySearchTree<int, int>();

        Assert.Equal(null, bst.Get(10));
    }

    [Fact]
    public static void TestGetReplaceOneVal() {
        BinarySearchTree<int, int> bst = new BinarySearchTree<int, int>();

        bst.Put(1, 1);
        bst.Put(10, 10);
        bst.Put(2, 2);
        bst.Put(-2, 1);
        bst.Put(10, 9);
        bst.Put(100, 12);
        bst.Put(10, 11);

        Assert.Equal(11, bst.Get(10));
    }
}
