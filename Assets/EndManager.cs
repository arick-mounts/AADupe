using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public Text highscoreName;
    public Text highscoreScore;

    // Start is called before the first frame update
    void Start()
    {
        highscoreName.text = PlayerPrefs.GetString("PlayerHighscore");
        highscoreScore.text = PlayerPrefs.GetInt("ScoreHighscore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
