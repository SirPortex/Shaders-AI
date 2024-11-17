using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IsEmotingAction (A)", menuName = "ScriptableObject/Actions/IsEmotingAction")] //IMPORTANTE
public class IsEmotingAction : Action //Hereda de action
{
    

    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReference>().target; // Cogemos la referencia del script de Target Reference, que es el prefab del AmongUs

        if (target.GetComponent<PlayerMovement_RB>().Emote()== true) //Comprobamos si el target esta realizando el Emote
        {
            return true;
        }

        return false;
    }

    public override void DrawGizmos(GameObject owner)
    {
        
    }
}
