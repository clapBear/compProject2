using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{
    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject UserCar;
    public GameObject AICar1;
    public GameObject AICar2;
    public GameObject AICar3;
    public GameObject AICar4;

    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        LapTimer.SetActive(false);
        yield return new WaitForSeconds(0.5f);

        CountDown.GetComponent<Text>().text = "Ready";
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);

        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);

        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);

        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(1);

        CountDown.SetActive(false);
        GoAudio.Play();
        LapTimer.SetActive(true);

        UserCar.GetComponent<CarUserControl>().enabled = true;
        AICar1.GetComponent<CarAIControl>().enabled = true;
        AICar2.GetComponent<CarAIControl>().enabled = true;
        AICar3.GetComponent<CarAIControl>().enabled = true;
        AICar4.GetComponent<CarAIControl>().enabled = true;
    }
}
