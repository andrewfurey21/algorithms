namespace Searching;
public class BinarySearchTree<K, V> where K: IComparable {

    private Node? root = null;
    private int size = 0;

    private class Node {
        private K key;
        public K Key {
            get {
                return this.key;
            }
        }
        private V val;
        public V Val {
            get {
                return this.val;
            }
        }
        public Node? leftLink;
        public Node? rightLink;


        public Node(K key, V val) {
            this.key = key;
            this.val = val;
        }
    }

    public int Size {
        get {
            return this.size;
        }
    }

    public BinarySearchTree() {}

    //public V Get(K key) {

    //}

    public void Put(K key, V val) {
        if (root == null) {
            root = new Node(key, val);
            return;
        }

        Node? currentNode = root;
        while (currentNode != null) {
            if (currentNode.Key.CompareTo(key) < 0) {
                currentNode = currentNode.leftLink;
            } else if (currentNode.Key.CompareTo(key) > 0) {
                currentNode = currentNode.rightLink;
            } else return;
        }

        if (currentNode == null) {
            currentNode = new Node(key, val);
        }
    }

    private int CalculateSize(Node? node) {
        if (node == null) {
            return 0;
        } else return 1 + CalculateSize(node.leftLink) + CalculateSize(node.rightLink);
    }

    //min, max, delete
}
