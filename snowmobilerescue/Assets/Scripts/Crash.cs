using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour
{
    public GameObject crashFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioController.playCrash = true;
            Handheld.Vibrate();
            Instantiate(crashFX, other.transform.position, other.transform.rotation);
            other.gameObject.SetActive(false);
        }
    }
}
