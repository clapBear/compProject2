using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
  public int incrementAmount;
  public GameObject player;
  public string Tag;

  void OnTriggerEnter(Collider col)
  {
    if (col.gameObject.tag != Tag)
    {
        this.player.GetComponent<CoinScore>().addScore(incrementAmount);
    }
      Destroy(this.gameObject);
  }
}
