using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestWhichUIController : MonoBehaviour
{
    [SerializeField] TestDialog testDialog;
    [SerializeField] Dialog dialog;
    public bool isChecked = false;
    public bool isKeyed = false;
    [SerializeField] TMP_Text text;
    [TextArea] public string[] fullText;
    private int i = 0;



    public void GetWhichText()
    {
        if (isKeyed)
        {
            i++;
        }

        if (i == fullText.Length - 1)
        {
            text.text = fullText[i];
            StartCoroutine(dialog.LogAndSceneIdou(text.text));

        }
        if (i < fullText.Length - 1)
        {
            text.text = fullText[i];

            StartCoroutine(dialog.Log(text.text));
            
        }

    }

}
