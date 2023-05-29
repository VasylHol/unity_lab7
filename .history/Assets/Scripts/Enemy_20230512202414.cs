using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    void Start()
    {
        transform.LookAt(target.transform.position);
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
