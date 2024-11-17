using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "WanderState (S)", menuName = "ScriptableObject/States/WanderState")] //IMPORTANTE


public class WanderState : State
{

    public float range;

    public Vector3 centrePoint;

    public string chaseParameters;


    public override State Run(GameObject owner)
    {
        State nextState = CheckActions(owner);
        NavMeshAgent navMeshAgent = owner.GetComponent<NavMeshAgent>();

        Animator anim = owner.GetComponent<Animator>();

        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {

            Vector3 point;

            if (RandomPoint(centrePoint, range, out point))
            {
                Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
                navMeshAgent.SetDestination(point);
            }
        }

        bool RandomPoint(Vector3 center, float range, out Vector3 result) // punto aleatorio 
        {
            Vector3 randomPoint = center + Random.insideUnitSphere * range; //Punto aleatrio en la esfera que este tocando la superficie del terreno
            NavMeshHit hit;

            if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) // waypoint 
            {
                result = hit.position;
                return true;
            }

            result = Vector3.zero;
            return false;
        }

        anim.SetFloat(chaseParameters, navMeshAgent.velocity.magnitude / navMeshAgent.speed); // aumentamos la velocidad del enemigo

        return nextState;
    }
}
