using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class generateAsteroids : MonoBehaviour {


    public GameObject [] obj;
    public float spawnMinX = -10;
    public float spawnMaxX = 10;
    public float spawnMinY = -10;
    public float spawnMaxY = 10;
    private float nextAsteroidTime = 2.5f;
    public float period = 0.1f;

    //public GameObject rndPlace;

    // Use this for initialization
    void Start () {

        
       // Spawn();
	}
	

    void Update()
    {
        if(Time.time > nextAsteroidTime)
        {
            nextAsteroidTime += period;
             Spawn();
        }
       
    }


    void Spawn()    {

        //instantiate - makes a copy of a gameobject(in your case obj)

        //to keep a handle on it you need to assign it to an empty game object

        //Steps:

        //1. Empty game object assign instantiated object to it
        //2. Get the gameObject and change position
        //NOTE: Random.Range gives back a float between 2 values(min - max)
       
        // Debug.Log("SetOBJ");
        
        

       GameObject tempObject = Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity) as GameObject;

        Vector3 tempPosition = tempObject.transform.position;

        tempPosition.x += Random.Range(spawnMinX, spawnMaxX);
        tempPosition.y += Random.Range(spawnMinY, spawnMaxY);

        tempObject.transform.position = tempPosition;
    }

}
 