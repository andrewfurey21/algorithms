namespace Fundamentals;
public class WeightedQuickUnion {
    private int[] id;
    private int numberOfComponents;
    private int[] sizes;

    public WeightedQuickUnion(int numberOfSites) {
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
        int currentSite = p;
        while (currentSite != id[currentSite]) {
            currentSite = id[currentSite];
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

    //Find max height of tree [2, 0, 2, 2, 2]
    public int MaxHeight() {
        int maxHeight = 1;
        for (int i = 0; i < id.Length; i++) {
            int currentSite = i;
            int currentHeight = 1;
            while (currentSite != id[currentSite]) {
                currentHeight++;
                currentSite = id[currentSite];
            }
            if (currentHeight > maxHeight) {
                maxHeight = currentHeight;
            }
        }
        return maxHeight;
    }
}
