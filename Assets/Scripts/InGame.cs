using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    public Text scoreText;
    public GameObject player;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        this.score = this.player.GetComponent<CoinScore>().getScore();
    }

    // Update is called once per frame
    void Update()
    {
        this.score = this.player.GetComponent<CoinScore>().getScore();
        this.scoreText.text = ""+this.score;
    }
}
