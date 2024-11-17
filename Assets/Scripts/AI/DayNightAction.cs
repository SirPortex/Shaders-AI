using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DayNightAction (A)", menuName = "ScriptableObject/Actions/DayNightAction")] //IMPORTANTE

public class DayNightAction : Action
{
    public override bool Check(GameObject owner)
    {
        float timerCurrent  = owner.GetComponent<TimeReference>().GetTimeController().timerCurrent; // cogemos el script que hace referencia al contador del tiempo dia/noche

        if(timerCurrent >= 32.6f && timerCurrent <= 79.4f) // si el valor del contador esta entre esos valores devuelve true
        {
            return true;
        }
        return false;
    }

    public override void DrawGizmos(GameObject owner)
    {
        
    }

}
