using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehavior : MonoBehaviour
{
   // public Text deathLable;
    public Vector3 playerStartPosition;
    
    void OnEnable()
    {
        //register for event
        MessageSystem.onPlayerSenario += PlayerReset;

    }

    void OnDisable()
    {
        //deregister from event
        MessageSystem.onPlayerSenario -= PlayerReset;
    }

    private void PlayerReset()
    {
        //gameObject.transform(0, 0, 0);
        transform.position = playerStartPosition;
       // PlayerdeathCount();
    }

    //void PlayerdeathCount()
        
    //{
    //    int deathCount = 3;
    //    if ( deathCount == 0)
    //    {
    //        SceneManager.LoadScene(4);
    //    }
    //    deathLable.text = string.Format("{ }",deathCount);
    //}
}
