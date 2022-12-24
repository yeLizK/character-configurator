using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FirstScreen;
    public GameObject SecondScreen;
    public GameObject ModularChar;
    
    public void OpenFirstScreen()
    {
        FirstScreen.SetActive(true);
        SecondScreen.SetActive(false);
        ModularChar.transform.position = new Vector3(0.273f, 0, -6.448f);
        ModularChar.transform.rotation = Quaternion.Euler(0, -170, 0);
    }
    public void OpenSecondScreen() 
    {
        FirstScreen.SetActive(false);
        SecondScreen.SetActive(true);
        ModularChar.transform.position = new Vector3(-0.62f, 0, -6.291f);
        ModularChar.transform.rotation = Quaternion.Euler(0, 170, 0);
    }

    public void ApplicationClose() { Debug.Log("Application Closed!"); }
}
