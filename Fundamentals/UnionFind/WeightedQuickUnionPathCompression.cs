namespace Fundamentals;
public class WeightedQuickUnionPathCompression {
    private int[] id;
    private int numberOfComponents;
    private int[] sizes;

    public WeightedQuickUnionPathCompression(int numberOfSites) {
        id = new int[numberOfSites];
        sizes = new int[numberOfSites];
        numberOfComponents = numberOfSites;
        for (int i = 0; i < numberOfComponents; i++) {
            id[i] = i;
            sizes[i] = 1;
        }
    }

    // Add a connection between p and q
    public void Union(int p, int q) {
        int pRoot = Find(p);
        int qRoot = Find(q);

        if (pRoot != qRoot) {
            int pSize = sizes[pRoot];
            int qSize = sizes[qRoot];

            if (pSize < qSize) {
                id[pRoot] = qRoot;
                sizes[qRoot] += sizes[pRoot];
            } else {
                id[qRoot] = pRoot;
                sizes[pRoot] += sizes[pRoot];
            }
            numberOfComponents--;
        }
    }

    //Component identifier for p
    public int Find(int p) {
        Fundamentals.Stack<int> nodesEncountered = new Fundamentals.Stack<int>();
        int currentSite = p;
        while (currentSite != id[currentSite]) {
            nodesEncountered.Push(currentSite);
            currentSite = id[currentSite];
        }

        while (!nodesEncountered.IsEmpty()) {
            id[nodesEncountered.Pop()] = currentSite;
        }
        return currentSite;
    }

    //Check if p and q are connected
    public Boolean Connected(int p, int q) {
        return Find(p) == Find(q);
    }

    //Find number of components
    public int Count() {
        return numberOfComponents;
    }
}
