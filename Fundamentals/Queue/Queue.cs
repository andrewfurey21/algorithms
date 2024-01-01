//using System;

namespace Fundamentals;
public class Queue<T> {
    private class Node {
        public T data;
        public Node next;
    }

    private int size = 0;
    public int Size {
        get {
            return this.size;
        }
    }

    private Node head;
    private Node tail;

    public Queue() {
        tail = new Node();
        head = tail;
    }

    public T Dequeue() {
        T data = head.data;
        if (size > 0) {
            size--;
            head = head.next;

        };
        return data;
    }

    public void Enqueue(T data) {
        size++;
        tail.data = data;
        tail.next = new Node();
        tail = tail.next;
    }

    public bool IsEmpty() {
        return size == 0;
    }
}
