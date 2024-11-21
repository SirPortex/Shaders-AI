using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "Deambular (S)", menuName = "ScriptableObject/States/Deambular")]

public class DeambularEstado : State
{
    public float maxTime;

    public float radius;

    private float currentTime;


    public override State Run(GameObject owner)
    {
        State nextState = CheckActions(owner);

        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();

        currentTime += Time.deltaTime;

        if (currentTime >= maxTime)
        {
            bool pointFound = false;
            do
            {
                Vector3 randomPoint = owner.transform.position + Random.insideUnitSphere * radius;
                //Saca un punto aleatorio en el radio de una esfera.

                NavMeshHit hit;

                if (NavMesh.SamplePosition(randomPoint, out hit, radius, NavMesh.AllAreas))
                {
                    navMeshAgent.SetDestination(hit.position);
                }
                //Comprueba si el punto aleatorio esta en la maya de navegacion
            }
            while (!pointFound);

            currentTime = 0;
        }
        
        return nextState;

    }
}
