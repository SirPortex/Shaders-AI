using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "PatrolState (S)", menuName = "ScriptableObject/States/PatrolState")] //IMPORTANTE

public class PatrolState : State
{
    public Vector3[] arrayPoints = new Vector3[1];

    public float maxTime;

    private float currenttime = 0;

    private int currentIndex = 0;

    public override State Run(GameObject owner)
    {
        

        State nextState = CheckActions(owner);
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>(); // al herederar de ScriptableObject hay que poner owner para poder heredar el componente de NavMeshAgent

        navMeshAgent.SetDestination(arrayPoints[currentIndex]);
        
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            currenttime += Time.deltaTime;

            if (currenttime >= maxTime)
            {
                currenttime = 0;
                currentIndex++;

                if (currentIndex >= arrayPoints.Length)
                {
                    currentIndex = 0;
                }
                
            }
        }
        //remainingDistance <= stoppingDistance o Mathf.approx 
 
        
        return nextState;
    }
}
