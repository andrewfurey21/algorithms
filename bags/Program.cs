using System;

public class Bag<T> where T : IComparable {
    private int size = 0;
    private int capacity = 10;
    private T[] data;

    public Bag() {
        data = new T[capacity];
    }

    public void Insert(T item) {
        size++;
        if (size > capacity) {
            Array.Resize(ref this.data, capacity * 2);
        }
        this.data[size-1] = item;
    }

    public bool Contains(T item) {
        for (int i = 0; i < size; i++) {
            if (item.CompareTo(this.data[i]) == 0) {
                return true;
            }
        }
        return false;
    }


}
