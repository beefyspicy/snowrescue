using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{

	void Update ()
    {
        if (CrossPlatformInputManager.GetButtonDown("Day"))
        {
            LoadGame1();
        }
        if (CrossPlatformInputManager.GetButtonDown("Night"))
        {
            LoadGame2();
        }
    }

    void LoadGame1()
    {
        SceneManager.LoadScene(1);
    }

    void LoadGame2()
    {
        SceneManager.LoadScene(2);
    }
}
