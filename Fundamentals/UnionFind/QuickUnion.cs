namespace Fundamentals;
public class QuickUnion {
    private int numberOfComponents;
    private int[] id;

    public QuickUnion(int numberOfSites) {
        numberOfComponents = numberOfSites;
        id = new int[numberOfSites];
        for (int i = 0; i < numberOfComponents; i++) {
            id[i] = i;
        }
    }

    // Add a connection between p and q
    public void Union(int p, int q) {
        int pRoot = Find(p);
        int qRoot = Find(p);

        if (pRoot != qRoot ) {
            id[qRoot] = pRoot;
        }

        numberOfComponents--;
    }

    //Component identifier for p (root)
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
}
