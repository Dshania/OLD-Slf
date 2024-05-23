using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActivePhone : MonoBehaviour
{
    public GameObject phone;
    public GameObject send;
    public GameObject back;
    public GameObject dragAndDrop;
    public TMP_Text textOnScreen;
    public TMP_InputField inputField;

    public int points;
    public scoreMangaer scoreMan;

    public void CallPhone()
    {
        phone.SetActive(true); 
        dragAndDrop.SetActive(false);
    }

    public void Send()
    {
        StartCoroutine(SendButton());
    }
    public IEnumerator SendButton()
    {
        textOnScreen.text = inputField.text;

        points= Random.Range(0, 80);
        scoreMan.AddPoint(points); 

        yield return new WaitForSeconds(4f);
        phone.SetActive(false);
        dragAndDrop.SetActive(true);
        
    }

    public void BackButton()
    {
        phone.SetActive(false);
        dragAndDrop.SetActive(true);
    }
}
