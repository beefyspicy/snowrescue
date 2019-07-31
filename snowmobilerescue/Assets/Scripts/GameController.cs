using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static float score;
    public static float dist;

    public static bool playGame;
    public static bool speedUp;

    public GameObject player;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject restartButton;
    public GameObject startButton;
    public GameObject homeButton;
    public GameObject snowFX;
    public GameObject startArea;
    public GameObject area1;
    public GameObject area2;
    public GameObject area3;

    public Text scoreText;
    public Text distanceText;
    public Text speedUpText;

    private void Start()
    {
        LoadLevel();
        score = 0;
        playGame = false;
        scoreText.text = "Score: " + score;
        distanceText.text = (int)dist/3 + "m";
        speedUpText.text = "";
    }

    void Update ()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (speedUp)
        {
            StartCoroutine(SpeedUp());
        }
        scoreText.text = "Score: " + score;
        distanceText.text = (int)dist/3 + "m";

        if (CrossPlatformInputManager.GetButtonDown("Start"))
        {
            startButton.SetActive(false);
            homeButton.SetActive(false);
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            snowFX.SetActive(true);

            playGame = true;
        }

        if (CrossPlatformInputManager.GetButtonDown("Home") && homeButton.activeSelf)
        {
            SceneManager.LoadScene(0);
        }

        if (!player.activeSelf)
        {
            restartButton.SetActive(true);
            if (CrossPlatformInputManager.GetButtonDown("Fire1"))
            {
                if (sceneName == "Day")
                {
                    SceneManager.LoadScene(1);
                }
                else if (sceneName == "Night")
                {
                    SceneManager.LoadScene(2);
                }
            }
            homeButton.SetActive(true);
            if (CrossPlatformInputManager.GetButtonDown("Home"))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    void LoadLevel()
    {
        float r = Random.Range(1, 4);
        if(r == 1)
        {
            Instantiate(area1, startArea.transform.position, startArea.transform.rotation);
        }
        if (r == 2)
        {
            Instantiate(area2, startArea.transform.position, startArea.transform.rotation);
        }
        if (r == 3)
        {
            Instantiate(area3, startArea.transform.position, startArea.transform.rotation);
        }
    }


    IEnumerator SpeedUp()
    {
        speedUpText.text = "Speed Increased!";
        yield return new WaitForSeconds(2f);
        speedUpText.text = "";
        speedUp = false;
    }
}
