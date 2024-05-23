using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ThemeRandom : MonoBehaviour
{
    public TMP_Text themeText;

    public void RandomTheme()
    {
        string[] themes = new string[] { "Office", "Supermarket", "Punk Rock", "Wedding", "Casual", "Date night", "Fitness", "Ballroom Hall", "Circus", "Animal", "Black and White", "Disco", "Wild West", "Pirate" };
        string randomTheme = themes[Random.Range(0, themes.Length)];
        themeText.text = randomTheme;
    }
}
