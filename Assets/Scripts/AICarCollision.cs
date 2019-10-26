using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarCollision : MonoBehaviour
{
    public int incrementAmount;
    public string coinTag;

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == coinTag)
        {
            this.GetComponent<AICoinScore>().addScore(incrementAmount);
            Destroy(col.gameObject);
        }
    }
}
