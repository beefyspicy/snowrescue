using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFollow : MonoBehaviour
{
    public float fspeed;

    private void FixedUpdate()
    {
        if (GameController.playGame)
            transform.Translate(transform.forward * fspeed, Space.World);
    }
}