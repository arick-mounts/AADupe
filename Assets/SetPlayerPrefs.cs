using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerPrefs : MonoBehaviour
{
    public Text timeText;

    void Start()
    {
        PlayerPrefs.SetFloat("Rotation", 1f);
        PlayerPrefs.SetFloat("Pin", 20f);
        PlayerPrefs.SetFloat("Timer", 30f);
        PlayerPrefs.SetInt("Lives", 2);
        PlayerPrefs.SetString("Name", "Default");
    }
    public void SetRotationSpeed(float input)
    {
        PlayerPrefs.SetFloat("Rotation", input);
    }

    public void SetPinSpeed(float input)
    {
        PlayerPrefs.SetFloat("Pin", input);
    }
    public void SetTimer(float input)
    {
        PlayerPrefs.SetFloat("Timer", input);
        timeText.text = input.ToString() ;
    }

    public void SetLives(int lives)
    {
        PlayerPrefs.SetInt("Lives", lives + 1);
    }

    public void SetName(string name)
    {
        PlayerPrefs.SetString("Name", name);
    }
}
