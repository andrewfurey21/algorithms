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
}
