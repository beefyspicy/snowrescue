using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    public Transform other;

    private void Update()
    {
        GameController.dist = Vector3.Distance(other.position, transform.position);
    }
}
