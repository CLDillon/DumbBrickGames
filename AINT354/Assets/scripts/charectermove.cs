using UnityEngine;
using System.Collections;

public class charectermove : MonoBehaviour
{



    private Transform movePlayer;
    public float force = 10;
    public float gravity = 9f;
    public Camera MainCamera;
    private Vector2 direction;
    private Rigidbody2D charecter;

    private bool isClicked = false;

  //  Use this for initialization
    void Start () {

        movePlayer = transform;
        charecter = GetComponent<Rigidbody2D>();

    }

 //   Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;

            Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);

            RaycastHit2D hit = Physics2D.Raycast(screenPos, Vector2.zero);

            //Debug.Log(hit.collider.name);

            if (hit.collider != null)
            {
                //Debug.DrawRay(transform.position, hit.point, Color.red);
                if (hit.transform.tag == "Player")
                {
                   // Debug.Log("Mouse Button down!");
                    isClicked = true;
                }
                else if (hit.transform.tag != "Player")
                {
                    isClicked = false;
                }
            }
        }

        if (Input.GetMouseButton(0))
        {
            if (isClicked == false)
                return;

            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10;

            Vector3 screenPos = Camera.main.ScreenToWorldPoint(mousePos);

            direction = (screenPos - movePlayer.position).normalized;
        }

        if (Input.GetMouseButtonUp(0))
        {
            charecter.velocity = -direction * force;

            isClicked = false;
        }
    }




}
