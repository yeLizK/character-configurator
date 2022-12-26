using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject FirstScreen;
    public GameObject SecondScreen;
    public GameObject ModularChar;

    private Camera mainCamera;
    private Vector3 cameraDefaultPos;
    private Vector3 headPos = new Vector3(-0.63f, 1.57f, -6.966f);
    private Vector3 UpperBodyPos = new Vector3(-0.63f, 1.245f, -7.7f);
    private Vector3 LowerBodyPos = new Vector3(-0.63f, 0.622f, -8.294f);

    private void Awake()
    {
        mainCamera = Camera.main;
        cameraDefaultPos = mainCamera.transform.position;
    }

    public void OpenFirstScreen()
    {
        FirstScreen.SetActive(true);
        SecondScreen.SetActive(false);
        ModularChar.transform.position = new Vector3(0.273f, 0, -6.448f);
        ModularChar.transform.rotation = Quaternion.Euler(0, -170, 0);
        SetCameraToDefaultPos();
    }
    public void OpenSecondScreen() 
    {
        FirstScreen.SetActive(false);
        SecondScreen.SetActive(true);
        ModularChar.transform.position = new Vector3(-0.62f, 0, -6.291f);
        ModularChar.transform.rotation = Quaternion.Euler(0, 170, 0);
    }

    public void SetCameraToHeadPos() 
    {
        
        mainCamera.transform.position = Vector3.Slerp(cameraDefaultPos,headPos, 1f );

    }
    public void SetCameraToUpperBodyPos()
    {

        mainCamera.transform.position = Vector3.Slerp(cameraDefaultPos, UpperBodyPos, 5f);

    }

    public void SetCameraToLowerBodyPos()
    {

        mainCamera.transform.position = Vector3.Slerp(cameraDefaultPos, LowerBodyPos, 5f);

    }

    public void SetCameraToDefaultPos()
    {
        mainCamera.transform.position = Vector3.Slerp(mainCamera.transform.position, cameraDefaultPos, 5f);
    }



    public void ApplicationClose() { Debug.Log("Application Closed!"); }
}
