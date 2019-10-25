using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour
{
  private int score = 0;

  public int getScore(){
    return this.score;
  }

  public void addScore(int i){
    this.score = this.score + i;
    Debug.Log(this.score);
  }
}
