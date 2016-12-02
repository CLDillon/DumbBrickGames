using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameSystem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadLevel(int levelIndex)
    {
        //Application.LoadLevel(levelIndex);
        SceneManager.LoadScene(levelIndex);
    }
}
