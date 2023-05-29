using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent myAgent;
    public GameObject target;
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();

        transform.LookAt(target.transform.position);
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
