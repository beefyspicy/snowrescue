using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed;
    public float fspeed;
    //public float tilt;
    //public float smooth;

    //private Rigidbody rb;

    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        //float moveVertical = Input.GetAxisRaw("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);

        /*if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, -45, 0);
            //transform.rotation = Quaternion.RotateTowards(0, -45, smooth * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 45, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }*/

        //transform.rotation = Quaternion.Euler(0, tilt, 0);

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);
        transform.Translate(transform.forward * fspeed, Space.World);

        //rb.velocity = transform.forward * fspeed;
    }
}
