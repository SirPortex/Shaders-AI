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
        float timerCurrent = owner.GetComponent<TimeReference>().GetTimeController().timerCurrent;

        State nextState = CheckActions(owner);
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();

        if (timerCurrent >= 27 && timerCurrent <= 30)
        {
            //owner.GetComponent<Animator>().SetFloat("Time",(timerCurrent - 27)/30f);

        }

        Debug.Log("Mimiendo Zzz");


        return nextState;

    }
}
