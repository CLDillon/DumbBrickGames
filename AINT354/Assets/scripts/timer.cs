using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {


    private float seconds = 0.0f;
    private float minutes = 0.0f;
    private float hours = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        seconds += Time.deltaTime;
        if (seconds > 60)
        {
            minutes += 1;
            seconds = 0;
        }
        if (minutes > 60)
        {
            hours += 1;
            minutes = 0;
        }
        Debug.Log(hours);
        Debug.Log(minutes);
        Debug.Log(seconds);
	}
}
