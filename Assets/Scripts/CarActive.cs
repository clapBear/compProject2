using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarActive : MonoBehaviour
{

	public GameObject CarControl;

	void Start()
	{
		CarControl.GetComponent<CarUserControl>().enabled = true;
	}
}