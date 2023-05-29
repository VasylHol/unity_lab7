using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpSpeed;

    private CharacterController characterController;
    private float ySpeed;
    private float originalStepOffset;

    public LayerMask canBeClicked;
    private NavMeshAgent myAgent;
    // [SerializeField] private float _playerspeed = 30f;
    [SerializeField] private float jumpforce = 3f;
    void Start() {
        myAgent = GetComponent<NavMeshAgent>();
        characterController = GetComponent<CharacterController>();
        originalStepOffset = characterController.stepOffset;

    }
    void Update( ){
        if(Input.GetMouseButton(0)){
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(myRay, out hitInfo,100, canBeClicked )){
                myAgent.SetDestination(hitInfo.point);
            }
        }

    }
   

}
