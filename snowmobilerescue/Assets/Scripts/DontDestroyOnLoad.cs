using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public GameObject bgm;
    //public GameObject gems;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        if (objs.Length > 1)
        {
            Destroy(bgm);
        }

        DontDestroyOnLoad(bgm);


        /*GameObject[] objs2 = GameObject.FindGameObjectsWithTag("GameController");

        if (objs2.Length > 1)
        {
            Destroy(gems);
        }

        DontDestroyOnLoad(gems);*/
    }
}
