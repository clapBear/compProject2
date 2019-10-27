using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halfPointTrigger : MonoBehaviour
{

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            LapCompleteTrig.SetActive(true);
            HalfLapTrig.SetActive(false);
        }
        
    }
}
