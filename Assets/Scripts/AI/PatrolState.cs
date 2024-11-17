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

        navMeshAgent.SetDestination(arrayPoints[currentIndex]); // Mandamos al agente al primer waypoint del index
        
        if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance) // Si la distancia que queda por recorrer es menor a la distancia de detencion...
        {
            currenttime += Time.deltaTime; // empezamos un contador

            if (currenttime >= maxTime) // si el contador llega al maximo valor
            {
                currenttime = 0; // se reincia el contador
                currentIndex++; // se aumenta el index, el agente va a otro waypoint

                if (currentIndex >= arrayPoints.Length) // si estamos en el ultimo waypoint se vuelve a reinciar el index
                {
                    currentIndex = 0;
                }
                
            }
        }
        //remainingDistance <= stoppingDistance o Mathf.approx 
 
        
        return nextState;
    }
}
