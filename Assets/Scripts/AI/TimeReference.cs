using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeReference : MonoBehaviour
{
    private TimeController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindAnyObjectByType<TimeController>();
    }

    public TimeController GetTimeController() //Getter
    {
        return controller;
    }

}
