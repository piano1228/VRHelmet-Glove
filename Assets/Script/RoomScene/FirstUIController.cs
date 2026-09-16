using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FirstUIController : MonoBehaviour
{

    [SerializeField] Dialog dialog;
    //[SerializeField] UIManager uIManager;

    [System.Serializable]
    public class DialogueLine
    {
        public bool isUta;
        [TextArea]
        public string[] text;
    }

    public DialogueLine[] lines;

    void Start()
    {
        GetText();
    }

    public void GetText()
    {
        StartCoroutine(dialog.Conversation(lines));
    }

}
