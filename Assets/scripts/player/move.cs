using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 3f;
    public float speed_prk_mp;
    public GameObject Player;
    private Rigidbody rb;

    Shot shot;
    public Transform gunBarrel;
    //public Transform groundCheck;
    //public LayerMask groundMask;
    public GameObject cursor;
    //public float jumpSpeed = 8.0f;
    //public float gravity = -9.8f;
    //public float jumpHeight = 3f;
    //Vector3 velocity;
    //bool isGrounded;
    //CharacterController characterController;
    //public float groundDist = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        //characterController = GetComponent<CharacterController>();
        rb = Player.GetComponent<Rigidbody>();
        shot = FindObjectOfType<Shot>();
        

    }

    // Update is called once per frame
    void Update()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);
        //if (isGrounded && velocity.y < 0)
        //{
        //    velocity.y = -2f;
        //}

        //float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        //float z = Input.GetAxis("Vertical");

        //if (Input.GetKey(KeyCode.Space) && isGrounded)
        //{
        //    velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}

        //Vector3 move = transform.right * x + transform.forward * z;
        //characterController.Move(move * jumpSpeed * Time.deltaTime);
        //velocity.y += gravity * Time.deltaTime;
        //characterController.Move(velocity * Time.deltaTime);



        // Move Forward
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.Translate(speed * Time.deltaTime * Vector3.forward);
        }

        // Move Back
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.Translate(speed * Time.deltaTime * Vector3.back);
        }

        // Move Right
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Translate(speed * Time.deltaTime * Vector3.right);
        }

        // Move Left
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        if (Input.GetMouseButtonDown(0))
        {
            var from = gunBarrel.position;
            var target = cursor.transform.position;
            var to = new Vector3(target.x, from.y, target.z);
            var direction = (to - from).normalized;

            RaycastHit hit;
            if (Physics.Raycast(from, to - from, out hit, 100))
                to = new Vector3(hit.point.x, from.y, hit.point.z);
            else
                to = from + direction * 100;
            shot.Show(from, to);
        }


        if (perks_.speed_prk_bl == true)
        {
            speed = 6f;
        }
        else
        {
            speed = 3f;
        }

    }
}
