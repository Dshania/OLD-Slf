using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public static int PlayerType;
    public GameObject ThemeWindow;
    public GameObject Buttons;

    public void Female()
    {
        PlayerType = 1;
        ThemeWindow.SetActive(true); 
    }

    public void Male()
    {
        PlayerType = 2;
        ThemeWindow.SetActive(true);
    }

    public void Back()
    {
        PlayerType = 0; 
        ThemeWindow.SetActive(false);
    }

    public void PlayGame()
    {
        Buttons.SetActive(false);
        StartCoroutine(WaitingTime());
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public IEnumerator WaitingTime()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
