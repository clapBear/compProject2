using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
  public int incrementAmount;
  public GameObject player;

  void OnDestroy()
  {
      this.player.GetComponent<CoinScore>().addScore(incrementAmount);
  }

}
