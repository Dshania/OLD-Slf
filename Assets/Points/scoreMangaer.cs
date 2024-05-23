using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreMangaer : MonoBehaviour
{
    public static scoreMangaer Instance; 
    
    public TMP_Text scoreText;
    int score = 0;

    private void Awake()
    {
       Instance = this;
    }

    void Start()
    {
        scoreText.text = score.ToString() + " Passa Points";
        PlayerPrefs.SetString("Score", "0");
    }

    public void AddPoint(int points)
    {
        score += points;
        scoreText.text = score.ToString() + " Passa Points";
        PlayerPrefs.SetString("Score", scoreText.text);
    }

    public void RemovePoint(int points) 
    {
        score -= points;
        scoreText.text = score.ToString() + " Passa Points";
        PlayerPrefs.SetString("Score", scoreText.text);
    }
}
