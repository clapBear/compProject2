using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCollision : MonoBehaviour
{
    public int incrementAmount;
    public string Tag;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Tag)
        {
            this.GetComponent<CoinScore>().addScore(incrementAmount);
            Destroy(col.gameObject);
        }

    }
}
