using UnityEngine;
using System.Collections;

public class AsteroidBehaviour : MonoBehaviour
{

	// Use this for initialization
	void OnEnable ()
    {
        //register for event
        MessageSystem.onDeathScenario += KillYourself;
       // MessageSystem.onGoodbyeAsteroid += Goodbye;
	}

    void OnDisable()
    {
        //deregister from event
        MessageSystem.onDeathScenario -= KillYourself;
        //MessageSystem.onGoodbyeAsteroid -= Goodbye;
    }
	
	private void KillYourself()
    {
        Destroy(gameObject);
        
    }

    public void Die()
    {
       // Debug.Log("Die");
        KillYourself();
    }
}
