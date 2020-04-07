using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float HorizonalMove = 0f;
    public float VerticalMove = 0f;
    public float ForwardForce = 500f;
    public float SidewaysForce = 5f;

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 30, 30);

        HorizonalMove = Input.GetAxisRaw("Horizontal");
        VerticalMove = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //Vector3 vec = new Vector3(HorizonalMove+ rb.position.x, rb.position.y, VerticalMove + rb.position.z);
        //rb.MovePosition(vec);

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("left"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }

}
