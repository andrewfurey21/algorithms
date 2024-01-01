
namespace DataStructures;
public class StackArray<T> {
    private T[] data;

    private int size = 0;
    private int capacity = 10;
    public int Size {
        get {
            return this.size;
        }
    }

    public StackArray() {
        data = new T[capacity];
    }

    public void Push(T item) {
        size++;
        if (size > capacity) {
            capacity *= 2;
            Array.Resize(ref this.data, capacity);
        }
        this.data[size-1] = item;
    }

    public T Pop() {
        T item = this.data[size-1];
        size--;
        if (size < capacity/4) {
            capacity /= 2;
            Array.Resize(ref this.data, capacity);
        }
        return item;
    }

    public bool IsEmpty() {
        return size == 0;
    }
}
