using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "TimePassedAction (A)", menuName = "ScriptableObject/Actions/TimePassedAction")] //IMPORTANTE

public class TimePassedAction : Action
{
    public float maxtime;
    
    public float currenttime = 0;
    public override bool Check(GameObject owner)
    {
        currenttime += Time.deltaTime; //Contador

        if (currenttime >= maxtime) // Si el currenttime supera el max time
        {
            currenttime = 0; // se reincia el contador a 0
            return true;
        }
        return false;
    }

    public override void DrawGizmos(GameObject owner)
    {

    }
}
