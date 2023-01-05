using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour
{
    public GameObject CredtisPanel;
    public GameObject MainMenuPanel;

    public void NewGame()
    {
        SceneManager.LoadScene("CharConfigurationScene");
    }

    public void LoadGame()
    {
        Debug.Log("Load");
        //TO-DO
    }

    public void OpenCredits()
    {
        MainMenuPanel.SetActive(false);
        CredtisPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        MainMenuPanel.SetActive(true);
        CredtisPanel.SetActive(false);
    }



    public void ApplicationClose() { Debug.Log("Application Closed!"); }
}
