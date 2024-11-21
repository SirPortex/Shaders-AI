using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "FleeState (S)", menuName = "ScriptableObject/States/FleeState")]

public class FleeState : State
{
    public override State Run(GameObject owner)
    {
        State nextState = CheckActions(owner);
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();
        TargetReference reference = owner.GetComponent<TargetReference>();
        

        Vector3 flee = (owner.transform.position - reference.target.transform.position).normalized;
        navMeshAgent.SetDestination(owner.transform.position + (flee * 5));
        return nextState;
    }
}
