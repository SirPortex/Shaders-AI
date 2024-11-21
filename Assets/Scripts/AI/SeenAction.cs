using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SeenAction (A)", menuName = "ScriptableObject/Actions/SeenAction")]

public class SeenAction : Action
{
    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReference>().target;
        ConeCollider collider = target.GetComponentInChildren<ConeCollider>();
        List<GameObject> targetViewList = collider.list;

        foreach (GameObject objectInVision in targetViewList)
        {
            if(owner == objectInVision)
            {
                Debug.Log("UN ENEMIGO DEL FORTNITE");
                return true;
            }
        }
        return false;
    }

    public override void DrawGizmos(GameObject owner)
    {
    
    }
}
