﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour {



    
    public string level = "MainLevel";

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D Collider2D)
    {
     //   Debug.Log("triiger enter");

        if (Collider2D.gameObject.tag == "Player")
            // Application.LoadLevel(level);
            SceneManager.LoadScene(2);
    }
}
