using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCounter : MonoBehaviour
{
    public static int touchedCount = 0;

    public static void AddTouch()
    {
        touchedCount++;
    }

    void OnDestroy()
    {
        // シーン移動前に保存
        PlayerPrefs.SetInt("TouchedCount", touchedCount);
    }
}

