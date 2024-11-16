using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCulo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement_RB>())
        {
            Destroy(this);
        }
    }
}
