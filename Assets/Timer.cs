using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text time;
    public GameManager gm;

    private float timeRemaining;
    private bool timerIsRunning = false;



    // Start is called before the first frame update
    void Start()
    {;
        timeRemaining = PlayerPrefs.GetFloat("Timer");
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning) {

            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                gm.End();
            } 
        }
        DisplayTime(timeRemaining);
    }

    void DisplayTime(float timeToDisplay)
    {
        float seconds = Mathf.FloorToInt(timeToDisplay);

        time.text = seconds.ToString();
    }
}
