using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgent : MonoBehaviour
{
    internal NavMeshPathStatus pathStatus;
    internal bool updatePosition;
    internal float angularSpeed;
    internal bool isOnNavMesh;
    internal Vector3 nextPosition;
    internal float speed;

    internal void ResetPath()
    {
        throw new NotImplementedException();
    }

    internal bool SetDestination(Vector3 position)
    {
        throw new NotImplementedException();
    }

    internal void Warp(Vector3 position)
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
