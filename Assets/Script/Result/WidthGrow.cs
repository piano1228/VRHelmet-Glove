using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidthGrow : MonoBehaviour
{
    public RectTransform bar;   // 黄色い線
    float t;

    void Start()
    {
        t = 0;
        bar.sizeDelta = new Vector2(0, bar.sizeDelta.y);
    }

    void Update()
    {
        if (t < 5f)
        {
            t += Time.deltaTime;
            float w = Mathf.Lerp(0, 200, t / 5f);
            bar.sizeDelta = new Vector2(w, bar.sizeDelta.y);
        }
    }
}
