
namespace Sorting;
public class PriorityQueue {
    private List<int> heap;
    public int Size {
        get {
            return heap.Count();
        }
    }
    public PriorityQueue() {
        heap = new List<int>();
    }

    public void Insert(int item) {
        heap.Add(item);
        Swim(heap.Count()-1);
    }

    public int Pop() {
        if (Size <= 0) {
            throw new InvalidOperationException("Cannot pop from empty queue.");
        }
        int data = heap[0];
        Swap(0, heap.Count()-1);
        heap.RemoveAt(heap.Count()-1);
        Sink(0);
        return data;
    }

    public Boolean IsEmpty() {
        return Size == 0;
    }

    public void Sink(int index) {
        int current = index;
        while (current < Size) {
            int child = current*2+1;
            if (child < Size - 1 && heap[child] > heap[child+1]) {
                child++;
            }

            if (child < Size && heap[current] > heap[child]) {
                Swap(current, child);
                current = child;
            } else break;
        }
    }

    public void Swim(int index) {
        int current = index;
        int parent = getParent(index);
        while (current > 0 && heap[current] < heap[parent]) {
            Swap(current, parent);
            current = parent;
            parent = getParent(current);
        }

    }

    private int getParent(int index) {
        return index % 2 == 0 ? index / 2 - 1 : index / 2;
    }

    private void Swap(int firstIndex, int secondIndex) {
        int temp = heap[firstIndex];
        heap[firstIndex] = heap[secondIndex];
        heap[secondIndex] = temp;
    }
}
