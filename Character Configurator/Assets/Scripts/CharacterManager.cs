using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance;
    public static CharacterManager Instance { get { return _instance; } }

    private string characterName = "";
    private int gender; // 0-male, 1-female
    public enum characeterRace {Knight, Freefolks, HighBloods};

    public TMP_InputField nameField;
    public GameObject firstScreen;
    public GameObject maleModel;
    public GameObject femaleModel;

    private void Awake()
    {
        if (_instance != null && _instance!= this )
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Update()
    {
        if(firstScreen.activeSelf)
        {
            characterName = nameField.text;
        }

    }

    public void SelectMale()
    {
        maleModel.SetActive(true);
        femaleModel.SetActive(false);
        gender = 0;
    }

    public void SelectFemale()
    {
        maleModel.SetActive(false);
        femaleModel.SetActive(true);
        gender = 1;
    }
}
