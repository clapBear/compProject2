using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarActive : MonoBehaviour
{

	public GameObject CarControl;
    public GameObject AIcar1;
    public GameObject AIcar2;
    public GameObject AIcar3;
    public GameObject AIcar4;


    void Start()
	{
		CarControl.GetComponent<CarUserControl>().enabled = true;
        AIcar1.GetComponent<CarAIControl>().enabled = false;
        AIcar2.GetComponent<CarAIControl>().enabled = false;
        AIcar3.GetComponent<CarAIControl>().enabled = false;
        AIcar4.GetComponent<CarAIControl>().enabled = false;
    }
}