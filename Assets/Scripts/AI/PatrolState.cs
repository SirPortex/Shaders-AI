using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "PatrolState (S)", menuName = "ScriptableObject/States/PatrolState")] //IMPORTANTE

public class PatrolState : State
{
    public Vector3 guardPoint01, guardPoint02;


    public override State Run(GameObject owner)
    {

        State nextState = CheckActions(owner);
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>(); // al herederar de ScriptableObject hay que poner owner para poder heredar el componente de NavMeshAgent

        navMeshAgent.SetDestination(guardPoint01);
        
        return nextState;
    }
}
