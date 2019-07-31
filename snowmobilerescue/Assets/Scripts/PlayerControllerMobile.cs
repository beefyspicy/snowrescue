using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerControllerMobile : MonoBehaviour {

    public float movementSpeed;
    public float fspeed;
    //public float speedUp;
    public float force;
    public float boost;
    //public float tilt;
    //public float smooth;

    public GameObject pickupFX;
    public GameObject pickupFX2;
    public GameObject boostFX;

    //private Rigidbody rb;

    //private void Start()
    //{
    //    //rb = GetComponent<Rigidbody>();
    //}

    void FixedUpdate()
    {
        if (GameController.playGame)
        {
            transform.Translate(transform.forward * fspeed, Space.World);   ////////

            float moveHorizontal = CrossPlatformInputManager.GetAxisRaw("Horizontal");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.02F);

            transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

            //Speed up after certain distance
            /*if(GameController.dist / 3 > 25)
            {
                fspeed = 0.8f;
                //GameController.speedUp = true;
            }*/
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gem1"))
        {
            //Handheld.Vibrate();
            AudioController.playGem1 = true;
            Vibration.Vibrate(40);
            Instantiate(pickupFX, transform.position, transform.rotation);
            other.gameObject.SetActive(false);
            GameController.score += 5;
        }
        if (other.gameObject.CompareTag("gem2"))
        {
            //Handheld.Vibrate();
            AudioController.playGem2 = true;
            Vibration.Vibrate(40);
            //Vibration.Vibrate(30);
            Instantiate(pickupFX2, transform.position, transform.rotation);
            other.gameObject.SetActive(false);
            GameController.score += 15;
        }
        if (other.gameObject.CompareTag("boost"))
        {
            //Handheld.Vibrate();
            AudioController.playBoost = true;
            Vibration.Vibrate(40);
            //Vibration.Vibrate(30);
            //Instantiate(boostFX, transform.position, transform.rotation);
            boostFX.SetActive(true);
            other.gameObject.SetActive(false);
            StartCoroutine(Boost());
        }
        if (other.gameObject.CompareTag("speedup"))
        {
            fspeed += 0.05f;
            GameController.speedUp = true;
        }
    }

    IEnumerator Boost()
    {
        fspeed += boost;
        yield return new WaitForSeconds(1.5f);
        fspeed -= boost;
        boostFX.SetActive(false);
    }
}
