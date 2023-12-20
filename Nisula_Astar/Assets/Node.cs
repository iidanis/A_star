using System.Collections;
using UnityEngine;

public class Node 
{
    public bool walkable;
    public Vector3 worldPosition;

    public int gCost;
    public int hCost;

    public Node (bool _walkable, Vector3 _worldPos)
    {
        walkable = _walkable;
        worldPosition = _worldPos;
    }

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }
}
