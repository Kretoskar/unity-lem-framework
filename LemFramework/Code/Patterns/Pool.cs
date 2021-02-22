using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool
{
    private Stack<GameObject> _inactive = new Stack<GameObject>();
    private GameObject _parent;

    public Stack<GameObject> Inactive => _inactive;

    public GameObject Parent => _parent;

    public Pool(GameObject parent)
    {
        _parent = parent;
    }
}
