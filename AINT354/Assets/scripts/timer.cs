using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public Text timmerLable;

    private float time;

    // Use this for initialization
    void Start() {

    }


    // Update is called once per frame
    void Update() {

        time += Time.deltaTime;
        string tempTime;


        var minutes = time / 60;
        var seconds = time % 60;
        var fraction = (time * 100) % 100;

        tempTime = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);

        timmerLable.text = tempTime;
       

    }



    void OnEnable()
    {
        //register for event
        MessageSystem.onTimmerResetSenario += TimerReset;

    }

    void OnDisable()
    {
        //deregister from event
        MessageSystem.onTimmerResetSenario -= TimerReset;
    }
    private void TimerReset()
    {

        Debug.Log(timmerLable.text);
        
     
      time = Time.deltaTime;
    }
   
}
