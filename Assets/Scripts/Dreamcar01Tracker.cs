using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dreamcar01Tracker : MonoBehaviour
{
    public GameObject Tracker;
	public GameObject Mark01;
	public GameObject Mark02;
	public GameObject Mark03;
	public GameObject Mark04;
	public GameObject Mark05;
	public GameObject Mark06;
	public GameObject Mark07;
	public GameObject Mark08;
	public GameObject Mark09;
	public GameObject Mark10;
	public GameObject Mark11;
	public GameObject Mark12;
	public GameObject Mark13;
	public GameObject Mark14;
	public GameObject Mark15;
	public GameObject Mark16;
	public int MarkTracker;

    void Update()
    {
		Tracking();
    }

    private void Tracking()
	{
		switch (MarkTracker)
		{
			case 0:
				changeTracker(Tracker, Mark01);
				break;
			case 1:
				changeTracker(Tracker, Mark02);
				break;
			case 2:
				changeTracker(Tracker, Mark03);
				break;
			case 3:
				changeTracker(Tracker, Mark04);
				break;
			case 4:
				changeTracker(Tracker, Mark05);
				break;
			case 5:
				changeTracker(Tracker, Mark06);
				break;
			case 6:
				changeTracker(Tracker, Mark07);
				break;
			case 7:
				changeTracker(Tracker, Mark08);
				break;
			case 8:
				changeTracker(Tracker, Mark09);
				break;
			case 9:
				changeTracker(Tracker, Mark10);
				break;
			case 10:
				changeTracker(Tracker, Mark11);
				break;
			case 11:
				changeTracker(Tracker, Mark12);
				break;
			case 12:
				changeTracker(Tracker, Mark13);
				break;
			case 13:
				changeTracker(Tracker, Mark14);
				break;
			case 14:
				changeTracker(Tracker, Mark15);
				break;
			case 15:
				changeTracker(Tracker, Mark16);
				break;
		}
	}
    private void changeTracker(GameObject Tracker, GameObject Marker)
	{
		Tracker.transform.position = Marker.transform.position;
	}

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Dreamcar01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkTracker += 1;
            if (MarkTracker == 16)
            {
                MarkTracker = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
