using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NodeSO", menuName = "SO/Node")]
public class NodeSO : ScriptableObject
{
    public float LifeTime;
    public bool IsStopNode;
    public bool IsBackMoveNode;
}
