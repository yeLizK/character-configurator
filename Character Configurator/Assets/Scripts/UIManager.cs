using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerMoveHandler
{
    public GameObject FirstScreen;
    public GameObject SecondScreen;
    public GameObject ModularChar;
    public GameObject HeadSelectionPanel;
    public GameObject UpperBodySelectionPanel;
    public GameObject LowerBodySelectionPanel;

    private Camera mainCamera;
    private Vector3 cameraDefaultPos;
    private Vector3 headPos = new Vector3(-0.63f, 1.57f, -6.966f);
    private Vector3 UpperBodyPos = new Vector3(-0.63f, 1.245f, -7.7f);
    private Vector3 LowerBodyPos = new Vector3(-0.63f, 0.622f, -8.294f);
    private Vector3 mouseInitialPos;
    private Vector3 mouseOffset;
    private Vector3 charRotation;
    private bool isCharRotating;
    private float mouseDragSensitivity;

    private void Awake()
    {
        mainCamera = Camera.main;
        cameraDefaultPos = mainCamera.transform.position;
    }
    private void Start()
    {
        charRotation = Vector3.zero;
        mouseDragSensitivity = 0.4f;
    }
    private void Update()
    {
        
        if(isCharRotating)
        {
            mouseOffset = (Input.mousePosition - mouseInitialPos);
            charRotation.y = (mouseOffset.x + mouseOffset.y) * 0.5f;
            ModularChar.transform.Rotate(charRotation);
            mouseInitialPos = Input.mousePosition;
        }
    }

    public void OpenFirstScreen()
    {
        FirstScreen.SetActive(true);
        SecondScreen.SetActive(false);
        //ModularChar.transform.position = new Vector3(0.273f, 0, -6.448f);
        //ModularChar.transform.rotation = Quaternion.Euler(0, -170, 0);
        SetCameraToDefaultPos();
    }
    public void OpenSecondScreen() 
    {
        FirstScreen.SetActive(false);
        SecondScreen.SetActive(true);
        //ModularChar.transform.position = new Vector3(-0.62f, 0, -6.291f);
        //ModularChar.transform.rotation = Quaternion.Euler(0, 170, 0);
    }

    public void SetCameraToHeadPos() 
    {
        HeadSelectionPanel.SetActive(true);
        UpperBodySelectionPanel.SetActive(false);
        LowerBodySelectionPanel.SetActive(false);
        mainCamera.transform.position = Vector3.Slerp(cameraDefaultPos,headPos, 1f );

    }
    public void SetCameraToUpperBodyPos()
    {
        HeadSelectionPanel.SetActive(false);
        UpperBodySelectionPanel.SetActive(true);
        LowerBodySelectionPanel.SetActive(false);
        mainCamera.transform.position = Vector3.Slerp(cameraDefaultPos, UpperBodyPos, 5f);

    }

    public void SetCameraToLowerBodyPos()
    {
        HeadSelectionPanel.SetActive(false);
        UpperBodySelectionPanel.SetActive(false);
        LowerBodySelectionPanel.SetActive(true);
        mainCamera.transform.position = Vector3.Slerp(cameraDefaultPos, LowerBodyPos, 5f);

    }

    public void SetCameraToDefaultPos()
    {
        HeadSelectionPanel.SetActive(false);
        UpperBodySelectionPanel.SetActive(false);
        LowerBodySelectionPanel.SetActive(false);
        mainCamera.transform.position = Vector3.Slerp(mainCamera.transform.position, cameraDefaultPos, 5f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (SecondScreen.activeSelf)
        {
            mouseInitialPos = Input.mousePosition;
            isCharRotating = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isCharRotating = false;
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if(isCharRotating)
        {
            mouseOffset = (Input.mousePosition - mouseInitialPos);
            charRotation.y = (mouseOffset.x + mouseOffset.y) * -mouseDragSensitivity;
            ModularChar.transform.Rotate(charRotation);
            mouseInitialPos = Input.mousePosition;
        }
    }
}
