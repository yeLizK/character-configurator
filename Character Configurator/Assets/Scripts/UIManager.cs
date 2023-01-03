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
    public Animator CameraAnim;

    private Vector3 mouseInitialPos;
    private Vector3 mouseOffset;
    private Vector3 charRotation;
    private bool isCharRotating;
    private float mouseDragSensitivity;

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
        SetCameraToDefaultPos();
    }
    public void OpenSecondScreen() 
    {
        FirstScreen.SetActive(false);
        SecondScreen.SetActive(true);
    }

    public void SetCameraToHeadPos() 
    {
        HeadSelectionPanel.SetActive(true);
        UpperBodySelectionPanel.SetActive(false);
        LowerBodySelectionPanel.SetActive(false);
        CameraAnim.SetTrigger("ZoomHead");

    }
    public void SetCameraToUpperBodyPos()
    {
        HeadSelectionPanel.SetActive(false);
        UpperBodySelectionPanel.SetActive(true);
        LowerBodySelectionPanel.SetActive(false);
        CameraAnim.SetTrigger("ZoomBody");

    }

    public void SetCameraToLowerBodyPos()
    {
        HeadSelectionPanel.SetActive(false);
        UpperBodySelectionPanel.SetActive(false);
        LowerBodySelectionPanel.SetActive(true);
        CameraAnim.SetTrigger("ZoomHips");

    }

    public void SetCameraToDefaultPos()
    {
        HeadSelectionPanel.SetActive(false);
        UpperBodySelectionPanel.SetActive(false);
        LowerBodySelectionPanel.SetActive(false);
        CameraAnim.SetTrigger("ZoomOut");
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
