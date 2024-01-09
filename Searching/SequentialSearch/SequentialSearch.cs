namespace Searching;
public class SequentialSearch<K, V>
    where K : IComparable
{

    private Node? current = null;
    private int size = 0;
    public int Size {
        get {
            return this.size;
        }
    }
    private class Node {
        public K key;
        public V val;
        public Node? prev;
        public Node(K key, V val, Node? prev) {
            this.key = key;
            this.val = val;
            this.prev = prev;
        }
    }

    public SequentialSearch() {

    }

    public void Put(K key, V val) {
        Node newNode = new Node(key, val, current);
        current = newNode;
        this.size++;
    }

    public V? Get(K key) {
        Node? checkNode = current;
        while (checkNode != null && checkNode.key.CompareTo(key) != 0) {
            checkNode = checkNode.prev;
        }
        if (checkNode == null) {
            throw new Exception("Could not find the key.");
        }
        return checkNode.val;
    }

    public Boolean Contains(K key) {
        Node? checkNode = current;
        while (checkNode != null && checkNode.key.CompareTo(key) != 0) {
            checkNode = checkNode.prev;
        }
        if (checkNode == null) {
            return false;
        }
        return true;
    }

    public Boolean IsEmpty() {
        return Size == 0;
    }
}
