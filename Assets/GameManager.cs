using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private bool gameHasEnded = false;
    public static int lives;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;
    public Text livesText;
    public Text PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        lives = PlayerPrefs.GetInt("Lives");
        PlayerName.text = PlayerPrefs.GetString("Name");
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = lives.ToString();
    }
    public bool CheckEnd()
    {
        return gameHasEnded;
    }

    public void EndGame()
    {

        if (lives > 0)
        {
            lives--;
            return;
        }
        if (gameHasEnded)
            return;
        End();
    }

    public void End()
    {

        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGame");
        gameHasEnded = true;
        if (Score.PinCount > PlayerPrefs.GetInt("ScoreHighscore"))
        {
            PlayerPrefs.SetInt("ScoreHighscore", Score.PinCount);
            PlayerPrefs.SetString("PlayerHighscore", PlayerPrefs.GetString("Name"));
        }
        Debug.Log("Game OVer Man");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}
