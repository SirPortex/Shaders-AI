using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SeenAction (A)", menuName = "ScriptableObject/Actions/SeenAction")]

public class SeenAction : Action
{
    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReference>().target;
        WhatAmILooking whatAmILooking = target.GetComponentInChildren<WhatAmILooking>();
        List<GameObject> targetViewList = whatAmILooking.viewList;

        foreach (GameObject objectInVision in targetViewList)
        {
            if(owner == objectInVision)
            {
                return true;
            }
        }
        return true;
    }

    public override void DrawGizmos(GameObject owner)
    {
    
    }
}
