using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestUIController : MonoBehaviour
{
    [SerializeField] TestDialog testDialog;
    public bool isChecked=false;
    [SerializeField] TMP_Text text;
    //[TextArea] public string fullText;
    [TextArea] public string[] fullText;
    private int i=0;


    public void GetText()
    {

        //  text.text=fullText;
        text.text = fullText[i];
        //  StartCoroutine(testDialog.Log(text.text));
        StartCoroutine(testDialog.Log(text.text));

        if (i < fullText.Length-1)
        {
            i++;
        }
    }
}
