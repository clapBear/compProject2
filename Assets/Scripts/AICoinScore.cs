using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICoinScore : MonoBehaviour
{
    private int score = 0;

    public int getScore()
    {
        return this.score;
    }

    public void addScore(int i)
    {
        this.score = this.score + i;
    }
}
