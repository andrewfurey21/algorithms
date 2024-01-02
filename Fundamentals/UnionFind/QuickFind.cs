namespace Fundamentals;
public class QuickFind {
    private int[] id;
    private int numberOfComponents;

    public QuickFind(int numberOfSites) {
        id = new int[numberOfSites];
        this.numberOfComponents = numberOfSites;
        for (int i = 0; i < numberOfComponents; i++) {
            id[i] = i;
        }
    }

    // Add a connection between p and q
    public void Union(int p, int q) {
        int idP = id[p];
        int idQ = id[q];

        if (idP != idQ) {
            for (int i = 0; i < id.Length; i++) {
                if (id[i] == idQ) {
                    id[i] = idP;
                }
            }
        }
        numberOfComponents--;
    }

    //Component identifier for p (id number)
    public int Find(int p) {
        return id[p];
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
