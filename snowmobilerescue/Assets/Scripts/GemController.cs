using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemController : MonoBehaviour
{
    float gems;
	
	void Update ()
    {
        gems = GameController.score;
	}
}
