using UnityEngine;
using System.Collections;

public class AsteroidBehaviour : MonoBehaviour
{

	// Use this for initialization
	void OnEnable ()
    {
        //register for event
        MessageSystem.onDeathScenario += KillYourself;
     
	}

    void OnDisable()
    {
        //deregister from event
        MessageSystem.onDeathScenario -= KillYourself;
    }
	
	private void KillYourself()
    {
        Destroy(gameObject);
        
    }
}
