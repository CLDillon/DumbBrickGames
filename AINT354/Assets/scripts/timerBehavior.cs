using UnityEngine;
using System.Collections;

public class timerBehavior : MonoBehaviour {


    public Time timeSinceLevelLoad;


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
       
    }
}
