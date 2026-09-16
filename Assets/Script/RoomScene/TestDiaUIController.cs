using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestDiaUIController : MonoBehaviour
{
    public TMP_Text text;
    [TextArea] public string[] fullText;
    [TextArea] public string  fullText1;

    public bool isChecked;
    [SerializeField] TestDialog testDialog;
    [SerializeField] Dialog dialog;

    private int i=0;
    public void GetDiary()
    {
        
      //text.text = fullText;

      StartCoroutine(dialog.AllDia(fullText));

        //if (i < fullText.Length - 1)
       // {
       //     i++;
       // }

    }



    public void GetDiary1()
    {

        //text.text = fullText;

        StartCoroutine(dialog.Dia(fullText1));

        //if (i < fullText.Length - 1)
        // {
        //     i++;
        // }

    }
}
