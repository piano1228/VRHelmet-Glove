using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LogManager : MonoBehaviour
{
    [SerializeField] TMP_Text text;
    [SerializeField] ScrollRect scrollRect;

    public void Log(string logText)
    {
        Canvas.ForceUpdateCanvases();
        scrollRect.verticalNormalizedPosition = 0f;
        text.text += "\n" + logText  + "\n";
    }
}
