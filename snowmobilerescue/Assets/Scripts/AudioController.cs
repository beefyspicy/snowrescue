using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static bool playCrash;
    public static bool playGem1;
    public static bool playGem2;
    public static bool playJump;
    public static bool playBoost;

    AudioSource audioSource;
    public AudioClip crash;
    public AudioClip gem1;
    public AudioClip gem2;
    public AudioClip jump;
    public AudioClip boost;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }
	
	void Update ()
    {
        if (playCrash)
        {
            audioSource.PlayOneShot(crash, .7f);
            playCrash = false;
        }
        if (playGem1)
        {
            audioSource.PlayOneShot(gem1, .35f);
            playGem1 = false;
        }
        if (playGem2)
        {
            audioSource.PlayOneShot(gem2, .35f);
            playGem2 = false;
        }
        if (playJump)
        {
            audioSource.PlayOneShot(jump, .7f);
            playJump = false;
        }
        if (playBoost)
        {
            audioSource.PlayOneShot(boost, .5f);
            playBoost = false;
        }
    }
}
