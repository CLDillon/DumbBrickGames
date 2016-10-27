﻿using UnityEngine;
using System.Collections;

public class charectermove : MonoBehaviour {

    

    private Transform movePlayer;
    public float force = 10;
    public float gravity = 9f;
    public Camera MainCamera;
    private Vector3 direction;
    private Rigidbody2D charecter;

	// Use this for initialization
	void Start () {

        movePlayer = transform;
        charecter = GetComponent<Rigidbody2D>();
        
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Player")
                {
                    Vector3 screenPos = MainCamera.WorldToScreenPoint(movePlayer.position);
                   
                    screenPos.z = 0;
                    direction = (screenPos - Input.mousePosition).normalized;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            charecter.velocity = direction * force;
        }
	}




}
