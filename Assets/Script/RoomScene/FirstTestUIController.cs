using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FirstTestUIController : MonoBehaviour
{

    [SerializeField] TestDialog testDialog;
    [SerializeField] TestUIManager testUIManager;

    [SerializeField] TMP_Text text;
    [TextArea] public string fullText;
    
  
    void Start()
    {
    testUIManager.OpenUI();
    GetText();
    }

    public void GetText()
    {
        text.text=fullText;

        StartCoroutine(testDialog.Log(text.text));
    }
}

