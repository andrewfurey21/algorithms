
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
            int child1 = current*2+1;
            int child2 = current*2+2;
            if (child1 < Size && heap[current] < heap[child1]) {
                Swap(current, child1);
                current = child1;
            } else if (child2 < Size && heap[current] < heap[child2]) {
                Swap(current, child2);
                current = child2;
            } else break;
        }
    }

    public void Swim(int index) {
        int current = index;
        int parent = getParent(index);
        while (current > 0) {
            if (heap[current] < heap[parent]) {
                break;
            }
            Swap(current, parent);
            current = parent;
            parent = getParent(current);
        }

    }

    private int getParent(int index) {
        return index % 2 == 0 ? index / 2 - 1 : index / 2;
    }

    public void Swap(int firstIndex, int secondIndex) {
        int temp = heap[firstIndex];
        heap[firstIndex] = heap[secondIndex];
        heap[secondIndex] = temp;
    }
}
