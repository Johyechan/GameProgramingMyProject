using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NodeBase : MonoBehaviour
{
    private NodeDead _nodeDead;

    protected virtual void Start()
    {
        _nodeDead = GetComponent<NodeDead>();
    }
}
