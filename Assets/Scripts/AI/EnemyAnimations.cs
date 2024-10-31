using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAnimations : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
       // animator.SetFloat("Speed", playerMovemen.GetMovementVector().magnitude / playerMovement.runningSpeed);
    }
}
