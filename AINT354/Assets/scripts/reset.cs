using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour {


   
    
    public string level = "MainLevel";

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D Collider2D)
    {
       // Debug.Log("I hit: " + Collider2D.gameObject.tag);
        if (Collider2D.gameObject.tag == "Player")
        
        {

            MessageSystem.BroadcastDeath();
            MessageSystem.PlayerReset();
            MessageSystem.TimerReset();

            
           // SceneManager.LoadScene(level);
        }
        else if (Collider2D.gameObject.tag == "Platform")
        {
            //Debug.Log("I hit inside: " + Collider2D.gameObject.tag);
            Collider2D.gameObject.GetComponent<AsteroidBehaviour>().Die();
          //  gameObject.GetComponent<AsteroidBehaviour>().Die();
        }
    }
    
    //void OnColliderEnter2D(Collision2D _colision)
    //{
    //    Debug.Log("I hit: " + _colision.gameObject.tag);
    //    if (_colision.gameObject.tag == "platform")
    //    {
    //        _colision.gameObject.GetComponent<AsteroidBehaviour>().Die();
    //    }
    //}
}

