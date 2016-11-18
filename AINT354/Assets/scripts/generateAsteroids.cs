using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class generateAsteroids : MonoBehaviour {


    public GameObject [] obj;
    public float spawnMin = -5f;
    public float spawnMax = 5f;
    // Use this for initialization
    void Start () {
        Spawn();
	}
	
    void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))],transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
    }

}
