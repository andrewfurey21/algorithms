using System;
using System.Collections;

namespace Fundamentals;
public class QuickUnion {
    public QuickUnion(int numberOfSites) {

    }


    // Add a connection between p and q
    public void Union(int p, int q) {

    }

    //Component identifier for p
    public int Find(int p) {
        return default(int);
    }

    //Check if p and q are connected
    public Boolean Connected(int p, int q) {
        return Find(p) == Find(q);
    }

    //Find number of components
    public int Count() {
        return default(int);
    }
}
