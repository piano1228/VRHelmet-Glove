using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] Dialog dialog;
    public bool isChecked = false;

    [System.Serializable]
    public class DialogueLine
    {
        public bool isUta;
        [TextArea]
        public string[] text;
    }

    public DialogueLine[] lines;

    public void GetText()
    {
        StartCoroutine(dialog.Conversation(lines));
    }
}
