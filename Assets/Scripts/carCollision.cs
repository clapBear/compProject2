using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class carCollision : MonoBehaviour
{
    public int incrementAmount;
    public string coinTag;

    void OnTriggerEnter(Collider col)
    {
      
        if (col.gameObject.tag == coinTag)
        {
            this.GetComponent<CoinScore>().addScore(incrementAmount);
            Destroy(col.gameObject);
        }
    }
}
