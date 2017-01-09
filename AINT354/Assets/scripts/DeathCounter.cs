using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DeathCounter : MonoBehaviour {

    public Text deathLable;
  
    //void OnEnable()
    //{
    //    //register for event
    //    //Currently deactivates my kill Zone
    //    MessageSystem.onPlayerSenario += PlayerdeathCount;

    //}


    // Update is called once per frame


        


    void PlayerdeathCount() {


        var PlayerDeathCounter = 3;


        PlayerDeathCounter =- 1;
      

            if (PlayerDeathCounter == 0)
        {
            SceneManager.LoadScene(4);
        }

        deathLable.text = string.Format("{0}", PlayerDeathCounter);
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
