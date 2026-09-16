using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EventManager : MonoBehaviour
{
    [SerializeField] private int unlockCount;
    [SerializeField] private int unlockCount2;
    [SerializeField] TestDialog testDialog;
    [SerializeField] Dialog dialog;

    [SerializeField] TestUIManager testUIManager;
    [SerializeField] TMP_Text text;
    [SerializeField] KidokuManager kidokuManager;
    [SerializeField] TestWhichUIController testWhichUIController;
    [TextArea] public string fullText;
    public void UnlockCheck()
    {
        Debug.Log("UnlockCheck呼ばれました");

        if (kidokuManager == null)
        {
            Debug.Log("ぬるだよ");
            return;
        }

        if (kidokuManager.checkedcount == unlockCount)
        {
            Debug.Log("条件満たしました");
            unlockCount--;
          //  testWhichUIController.isKeyed=true;
            text.text = fullText;
            StartCoroutine(dialog.EventLog(text.text));
        }

    }

    public void UnlockCheck2()
    {
        Debug.Log("UnlockCheck2呼ばれました");

        if (kidokuManager == null)
        {
            Debug.Log("ぬるだよ");
            return;
        }

        if (kidokuManager.checkedcount == unlockCount2)
        {
            Debug.Log("条件満たしました");
            unlockCount2++;
            //testWhichUIController.isKeyed = true;
            text.text = fullText;
            StartCoroutine(testDialog.EventLog2(text.text));
        }

    }


}