using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    float count = 0;

    public static bool onGround;

    public GameObject jumpFX;
    public GameObject player;

    private void OnTriggerStay(Collider other)
    {
        onGround = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        count++;
        if (other.gameObject.CompareTag("ground") && count > 1)
        {
            AudioController.playJump = true;
            Vibration.Vibrate(40);
            Instantiate(jumpFX, player.transform.position, player.transform.rotation);
            onGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        onGround = false;
    }
}
