using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "SleepState (S)", menuName = "ScriptableObject/States/SleepState")] //IMPORTANTE


public class SleepState : State
{
    public override State Run(GameObject owner)
    {
        State nextState = CheckActions(owner);
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();

        Debug.Log("Mimiendo Zzz");


        return nextState;

    }
}
