using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SeeAction (A)", menuName = "ScriptableObject/Actions/SeeAction")] //IMPORTANTE
public class SeeAction : Action // dar a la bombilla para que lo complete bien la estructura
{
    public float vision;
    public override bool Check(GameObject owner)
    {
        GameObject target = owner.GetComponent<TargetReference>().target; //Cogemos al Target para saber a que perseguir
        ConeCollider coneCollider = owner.GetComponentInChildren<ConeCollider>(); // Cogemos el cono que va a ser la vision
        List<GameObject> visionList = coneCollider.GetVisionList(); // Cogemos la lista de las colisiones del cono 
        foreach (GameObject gameObjectInVision in visionList) // Por cada objeto que colisiona  con el cono
        {
            if(gameObjectInVision == target) //comprobamos si el el target (among us)
            {
                return true; 
            }
        }
        return false;
    }
    

    public override void DrawGizmos(GameObject owner)
    {
        
    }
}
