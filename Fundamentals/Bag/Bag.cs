using System;
using System.Collections;

namespace DataStructures;
public class Bag<T>: IEnumerable where T : IComparable {
    private int size = 0;
    public int Size {
        get {
            return this.size;
        }
    }
    private int capacity = 10;
    private T[] data;

    public Bag() {
        data = new T[capacity];
    }

    public void Insert(T item) {
        size++;
        if (size > capacity) {
            capacity *= 2;
            Array.Resize(ref this.data, capacity);
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

    public bool IsEmpty() {
        return size == 0;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return this.GetEnumerator();
    }

    public IEnumerator GetEnumerator() {
        for (int i = 0; i < size; i++) {
            yield return this.data[i];
        }
    }


}
