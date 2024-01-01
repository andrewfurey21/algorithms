using System;

namespace DataStructures;
public class LinkedList<T>{
    private int size = 0;
    public int Size {
        get {
            return this.size;
        }
    }

    private class Node {
        public T item;
        public Node prev;

        public Node() {}

        public Node(Node prev) {
            this.prev = prev;
        }
    }

    Node head;

    public LinkedList() {
    }

    public T Get(int index) {
        if (index >= size || index < 0) {
            return default(T);
        }
        Node check = head;
        T item = default(T);
        for (int i = 0; i < (size-index); i++) {
            check = check.prev;
            item = check.item;
        }
        return item;
    }

    //public void Insert(T item, int index) {

    //}

    //public T Remove() {
    //
    //}

    public void Push(T item) {
        size++;
        Node newNode = new Node(head);
        head = newNode;
        head.item = item;
    }

    public T Pop() {
        T item = head.item;
        head = head.prev;
        size--;
        return item;
    }

    //TODO: sort, enumerate
}
