using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DayNightAction (A)", menuName = "ScriptableObject/Actions/DayNightAction")] //IMPORTANTE

public class DayNightAction : Action
{
    public override bool Check(GameObject owner)
    {
        float timerCurrent  = owner.GetComponent<TimeController>().timerCurrent;

        if(timerCurrent >= 32.6f && timerCurrent <= 79.4f)
        {
            return true;
        }
        return false;
    }

    public override void DrawGizmos(GameObject owner)
    {
        
    }

}
