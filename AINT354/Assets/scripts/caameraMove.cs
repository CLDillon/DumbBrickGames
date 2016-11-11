using UnityEngine;
using System.Collections;

public class caameraMove : MonoBehaviour {

    public Transform player;

	
	// Update is called once per frame
	void Update () {
       // transform.position = new Vector3(player.position.x + 0, 0, -10);
        transform.position = new Vector3(0, player.position.y, -10);
      
      
    }
}
