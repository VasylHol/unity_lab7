using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent myAgent;
    int i;
    public List<Transform> targets;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();

       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
