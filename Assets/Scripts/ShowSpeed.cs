using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class ShowSpeed : MonoBehaviour
{
    public Text Speed;
    public GameObject Car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CarController script = Car.GetComponent<CarController>();

        Speed.text = Mathf.RoundToInt(script.NowSpeed).ToString();
    }
}
