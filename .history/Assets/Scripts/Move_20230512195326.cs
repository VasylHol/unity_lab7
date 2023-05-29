using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    private Vector3 inpVect;
    public LayerMask canBeClicked;
    private Rigidbody _rb;
    private NavMeshAgent myAgent;
    [SerializeField] private float _playerspeed = 30f;
    void Start() {
        _rb = GetComponent<Rigidbody>();
        myAgent = GetComponent<NavMeshAgent>();

    }
    void Update( ){
        if(Input.GetMouseButton(0)){
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(myRay, out hitInfo,100, canBeClicked )){
                myAgent.SetDestination(hitInfo.point);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space)) {Jump();}
    }
    void Jump(){

    }

}
