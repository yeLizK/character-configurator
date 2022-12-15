using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FirstScreen;
    public GameObject SecondScreen;
    
    public void OpenFirstScreen()
    {
        FirstScreen.SetActive(true);
        SecondScreen.SetActive(false);
    }
    public void OpenSecondScreen() 
    {
        FirstScreen.SetActive(false);
        SecondScreen.SetActive(true);
    }

    public void ApplicationClose() { Debug.Log("Application Closed!"); }
}
