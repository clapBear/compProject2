using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;


    public GameObject RankPanel;

    void OnTriggerEnter(Collider col)
    {
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;

        if(col.tag == "Player")
        {
            if (LapCompleteTrig.activeSelf)
            {
                ShowRanking();
            }
            HalfLapTrig.SetActive(true);
            LapCompleteTrig.SetActive(false);
        }
    }
    void ShowRanking()
    {
        
        Debug.Log("show ranking");
        RankPanel.SetActive(true);
        StartCoroutine(CalcRanking());
        Time.timeScale = 0;
    }

    IEnumerator CalcRanking()
    {
        yield return new WaitForSeconds(1.0f);
    }
}

