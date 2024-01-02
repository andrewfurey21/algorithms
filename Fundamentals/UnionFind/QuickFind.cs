using System;
using System.Collections;

namespace Fundamentals;
public class QuickFind {
    private int[] id;
    private int numberOfComponents;
    public QuickFind(int numberOfSites) {
        int[] id = new int[numberOfSites];
        this.numberOfComponents = numberOfSites;
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

    //Component identifier for p
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
