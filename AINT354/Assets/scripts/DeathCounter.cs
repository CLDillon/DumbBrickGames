using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DeathCounter : MonoBehaviour {

    public Text deathLable;
    public  int PlayerDeathCounter = 4;
    

    void Start()
    {
      //  Debug.Log(deathLable);
        deathLable.text = "Lives: " + PlayerDeathCounter;
        PlayerdeathCount();
    }


    void OnEnable()
    {
        //register for event
        //Currently deactivates my kill Zone
        MessageSystem.onPlayerSenario += PlayerdeathCount;

    }


    // Update is called once per frame







    //void OnEnable()
    //{
    //    //register for event
    //    MessageSystem.onLifeReset += PlayerdeathCount;

    //}

    //void OnDisable()
    //{
    //    //deregister from event
    //    MessageSystem.onLifeReset -= PlayerdeathCount;
    //}

    void PlayerdeathCount() {

        //
        //Debug.Log("Death test");
        


       var  tepDeth = PlayerDeathCounter - 1;

        PlayerDeathCounter = tepDeth;

       // Debug.Log(PlayerDeathCounter);

            if (PlayerDeathCounter == 0)
        {
            new WaitForSeconds(5);
            SceneManager.LoadScene(4);
        }
            if (deathLable.text != null)
        deathLable.text = "Lives: " + PlayerDeathCounter;

    }

    //void PlayerdeathCount()

    //{


    //    int deathCount = 3;

    //    if (deathCount == 0)
    //    {
    //        SceneManager.LoadScene(4);
    //    }
    //    deathLable.text = string.Format("{ }", deathCount);
    //}
}
