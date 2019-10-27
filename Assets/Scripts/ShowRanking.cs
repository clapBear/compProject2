using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanking : MonoBehaviour
{
    public Text Rank;
    public Text userScore;
    public Text AIScore1;
    public Text AIScore2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int userS = int.Parse(userScore.text);
        int AIS1 = int.Parse(AIScore1.text);
        int AIS2 = int.Parse(AIScore2.text);

        if (userS>=AIS1 && userS >= AIS2)
        {
            Rank.text = "1";
        }
        else if((userS<AIS1 && userS>=AIS2)||(userS < AIS2 && userS >= AIS1))
        {
            Rank.text = "2";
        }
        else if(userS < AIS1 && userS < AIS2)
        {
            Rank.text = "3";
        }
    }

}
