using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public GameObject settingsScene;
    public GameObject menuScene;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Settings()
    {
        settingsScene.SetActive(true);
        menuScene.SetActive(false);
    }
    
    public void Backbttn()
    {
        settingsScene.SetActive(false);
        menuScene.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Game closed");
        Application.Quit();
    }

    public void MainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void CharacterSelectionLoad()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

}
