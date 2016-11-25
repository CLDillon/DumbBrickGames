using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour
{
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
    }
}
