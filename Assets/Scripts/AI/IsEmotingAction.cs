using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IsEmotingAction (A)", menuName = "ScriptableObject/Actions/IsEmotingAction")] //IMPORTANTE
public class IsEmotingAction : Action
{
    

    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReference>().target;
        //target.GetComponent<PlayerMovement_RB>();

        if (target.GetComponent<PlayerMovement_RB>().Emote()== true)
        {
            return true;
        }

        return false;
    }

    public override void DrawGizmos(GameObject owner)
    {
        
    }
}
