using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawn : MonoBehaviour
{
    public GameObject player;

    public GameObject hazard;
    public GameObject hazard2;
    public GameObject hazard3;
    public GameObject hazard4;
    public GameObject hazard5;
    public GameObject hazard6;
    public GameObject hazard7;
    public GameObject hazard8;
    public GameObject hazard9;

    public GameObject speedUpCollider;

    public GameObject spawn;

    //public Vector3 spawnValues;

    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    /*void Start()
    {
        StartCoroutine(SpawnWaves());
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("begin"))
        {
            Debug.Log("begin work");
            StartCoroutine(SpawnWaves());
        }
    }


    IEnumerator SpawnWaves()  //IEnumerator is the return value
    {
        yield return new WaitForSeconds(startWait);  //player gets ready
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                float r = Random.Range(1, 10);
                //Debug.Log(r);
                //float r = 1;
                //Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                //Quaternion spawnRotation = Quaternion.identity;
                if(r == 1)
                {
                    //Instantiate(hazard, spawnosition, spawnRotation);
                    Instantiate(hazard, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 2)
                {
                    Instantiate(hazard2, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 3)
                {
                    Instantiate(hazard3, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 4)
                {
                    Instantiate(hazard4, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 5)
                {
                    Instantiate(hazard5, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 6)
                {
                    Instantiate(hazard6, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 7)
                {
                    Instantiate(hazard7, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 8)
                {
                    Instantiate(hazard8, spawn.transform.position, spawn.transform.rotation);
                }
                else if (r == 9)
                {
                    Instantiate(hazard9, spawn.transform.position, spawn.transform.rotation);
                }
                //Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);  //waits after each spawn
            }
            Instantiate(speedUpCollider, spawn.transform.position, spawn.transform.rotation);
            yield return new WaitForSeconds(waveWait);
        }
    }
}
