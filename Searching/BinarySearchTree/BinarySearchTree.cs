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
            set {
                val = value;
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
            size++;
            return;
        }

        Node? currentNode = root;
        Node? prevNode = null;
        bool left = false;
        while (currentNode != null) {
            if (currentNode.Key.CompareTo(key) > 0) {
                prevNode = currentNode;
                currentNode = currentNode.leftLink;
                left = true;
            } else if (currentNode.Key.CompareTo(key) < 0) {
                prevNode = currentNode;
                currentNode = currentNode.rightLink;
                left = false;
            } else {
                currentNode.Val = val;
                return;
            }
        }

        if (left) {
            prevNode.leftLink = new Node(key, val);
        } else {
            prevNode.rightLink= new Node(key, val);
        }
        size++;
    }

    public override String ToString() {
        return Stringify(root);
    }

    private String Stringify(Node? n) {
        if (n == null) return "(null)";
        else {
            String left = Stringify(n.leftLink);
            String right= Stringify(n.rightLink);
            return String.Format("({0}, {1}), {2}, {3}", n.Key, n.Val, left, right);
        }
    }

    //min, max, delete
}
