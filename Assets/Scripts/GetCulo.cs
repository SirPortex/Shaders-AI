using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCulo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement_RB>())
        {
            Debug.Log("Recuperaste tu culo");
            Destroy(gameObject);
            GameManager.instance.LoadScene("Victory");
        }
    }
}
