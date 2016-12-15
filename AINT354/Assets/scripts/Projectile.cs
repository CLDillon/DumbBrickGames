using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    private Transform m_transform;
    public GameObject dotPrefab;
    private Transform[] m_bunchOfDots;
    public float force = 10;
    public float gravity = 9.81f;
    public Camera mainCam;
    private Vector3 m_direction;
    private Rigidbody m_rigidbody;


	// Use this for initialization
	void Start () 
    {
        m_transform = transform;
        m_bunchOfDots = new Transform[10];
        m_rigidbody = GetComponent<Rigidbody>();

        for(int i = 0; i < m_bunchOfDots.Length; i++)
        {
            GameObject tempObj = Instantiate(dotPrefab) as GameObject;
            m_bunchOfDots[i] = tempObj.transform;

            m_bunchOfDots[i].gameObject.SetActive(false);

        }
        //show how to work
        //float tempFloat = 1.5f;
        //int tempInt = 1;

        //float result = (int)tempFloat * tempInt;
        //Debug.Log(result);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Player")
                {
                Vector3 screenPos = mainCam.WorldToScreenPoint(m_transform.position);
                 screenPos.z = 0;
                  m_direction = (screenPos - Input.mousePosition).normalized;
                 
                }
            }Aim();

          
        }
        



        
        
        if (Input.GetMouseButtonUp(0) )
        {
            for (int i =0; i < m_bunchOfDots.Length; i++)
            {
                m_bunchOfDots[i].gameObject.SetActive(false);
            }
            m_rigidbody.velocity = m_direction * force;
        }
	
	}

    private void Aim()
    {
        float Sx = m_direction.x * force;
        float Sy = m_direction.y * force;

        for( int i = 0; i < m_bunchOfDots.Length; i++)
        {
            float t = i * 0.1f;
            float dx = Sx * t;
            float dy = (Sy *t) - (0.5f*gravity*(t*t));

            m_bunchOfDots[i].position = new Vector3(dx + m_transform.position.x, dy+m_transform.position.y, 0.0f);

            m_bunchOfDots[i].gameObject.SetActive(true);
            
        }


    }

}
