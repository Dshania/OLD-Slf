using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScore : MonoBehaviour
{
    public GameObject currentScore;
  //  public GameObject highScore;
    scoreMangaer scoreMan;

   // private TMP_Text highScoreText;
    private TMP_Text currentScoreText;

    void Start()
    {
        currentScoreText = currentScore.GetComponent<TMP_Text>();
        //  highScoreText = highScore.GetComponent<TMP_Text>();

        //  scoreMan = GameObject.FindGameObjectWithTag("Score").GetComponent<scoreMangaer>();
        currentScoreText.text = PlayerPrefs.GetString("Score");
    }

}
