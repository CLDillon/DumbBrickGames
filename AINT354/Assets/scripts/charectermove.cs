using UnityEngine;
using System.Collections;

public class charectermove : MonoBehaviour
{

    public Transform top_left;
    public Transform bottom_right;

    private Transform movePlayer;
    public float forceMultiplier = 1.5f;
    public float gravity = 9f;
    public Camera MainCamera;
    private Vector2 direction;
    private Rigidbody2D charecter;

    [SerializeField]private LayerMask m_WhatIsGround;
    const float k_GroundedRadius = 0.00000000000002f;
    private bool m_Grounded = false;
   // private Transform m_GroundCheck;

    private float magnitude = 0;

    private bool isClicked = false;
    //private bool inAir = false;

  //  Use this for initialization
    void Start () {

        movePlayer = transform;
        charecter = GetComponent<Rigidbody2D>();

    }

    private void Awake()
    {
        // Setting up references.
      //  m_GroundCheck = transform.Find("GroundCheck");

    }


    //   Update is called once per frame
    void FixedUpdate()
    {
        CheckGrounded();
        charecterJump();
      
    }
    void charecterJump()
    {
        if (!m_Grounded)
        {
            return;
          // Debug.Log("not grounded");
        }
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

            Vector3 tempDirection = screenPos - movePlayer.position;

            magnitude = tempDirection.magnitude * forceMultiplier;
            //   Debug.Log(magnitude);

            direction = tempDirection.normalized;
        }

        if (Input.GetMouseButtonUp(0))
        {
            charecter.velocity = -direction * magnitude;

            isClicked = false;
        }
    }

    //void Update()
    //{

    //    //Collider2D[] colliders = Physics2D.OverlapCircleAll(movePlayer.position, k_GroundedRadius);
    //    //m_Grounded = false;
    //    ////Debug.Log("Not Grounded Initial");
    //    //for (int i = 0; i < colliders.Length; i++)
        
    //    //{
    //    //    if (colliders[i].gameObject != gameObject)
    //    //    {
    //    //        m_Grounded = true;
    //    //        Debug.Log("Not Grounded");
    //    //        return;
    //    //    }
    //    //    else
    //    //    {
    //    //        m_Grounded = true;
    //    //        Debug.Log("Grounded");
    //    //    }
    //    //}

    //    // The player is grounded if a circlecast to the groundcheck position hits anything designated as ground
    //    // This can be done using layers instead but Sample Assets will not overwrite your project settings.

    //    //Collider2D[] colliders = Physics2D.OverlapCircleAll(movePlayer.position, k_GroundedRadius, m_WhatIsGround);
    //    //for (int i = 0; i < colliders.Length; i++)
    //    //{
    //    //    if (colliders[i].gameObject != gameObject)
    //    //        m_Grounded = true;
    //    //}
    //}

    private void CheckGrounded()
    {
        m_Grounded = Physics2D.OverlapArea(top_left.position, bottom_right.position, m_WhatIsGround);
        Debug.Log(m_Grounded);

        //Vector3 direction = (transform.position - new Vector3(transform.position.x, transform.position.y + 20, transform.position.z)).normalized;
        //RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 15.0f);

        ////Debug.Log(hit.collider.name);

        //Debug.DrawRay(transform.position, transform.position - new Vector3(transform.position.x, transform.position.y + 15, transform.position.z), Color.red);

        //if (hit.collider != null)
        //{
        //    if(hit.transform.name != "charecter")
        //    {
        //        Debug.Log(hit.transform.name);
        //    }

        //    return;
        //    //Debug.DrawRay(movePlayer.position, movePlayer.position + hit.point, Color.red);
        //    Debug.Log(hit.transform.name);
        //    if (hit.transform.tag == "Platform")
        //    {

        //        // Debug.Log("Mouse Button down!");
        //        m_Grounded = true;
        //        //Debug.Log("Grounded");

        //    }
        //    else
        //    {
        //        m_Grounded = false;
        //        //Debug.Log("Not Grounded");
        //    }
        //}
        //else
        //{
        //    m_Grounded = false;
        //    //Debug.Log("Not Grounded");

    }

}
