using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultBar : MonoBehaviour
{
    public RectTransform bar;
    float t;
    float maxWidth;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip videoLecordSE;

    bool sePlayedB =false;
    bool sePlayedA = false;
    bool sePlayedS = false;
    bool scorePlayedB = false;
    bool scorePlayedA = false;
    bool scorePlayedS = false;

    [SerializeField] TMP_Text text;



    void Start()
    {
        t = 0;

        // シーンAで触れた数を取得
        int count = PlayerPrefs.GetInt("TouchedCount", 0);

        Debug.Log("TouchedCount = " + count); 

        // 触れた数を 0〜1 に正規化（例：最大10個触れたら満タン）
        float ratio = Mathf.Clamp01(count / 10f);

        ratio = 10;//実験的に入れているだけ、これをコメントアウトしたら本来の動きになる。

        // 最終的に伸びる幅を決定
        maxWidth = 64.5f * ratio;

        // 最初は0
        bar.sizeDelta = new Vector2(0, bar.sizeDelta.y);
    }

    void Update()
    {
        if (t < 4f)
        {
            //SECheck();
            t += Time.deltaTime;
            float w = Mathf.Lerp(0, maxWidth, t / 4f);

            bar.sizeDelta = new Vector2(w, bar.sizeDelta.y);

            if (!sePlayedB && w >= 215f)
            {
                audioSource.PlayOneShot(videoLecordSE);
                sePlayedB = true;
            }

            if (!sePlayedA && w >= 430f)
            {
                audioSource.PlayOneShot(videoLecordSE);
                sePlayedA = true;
            }

            if (!sePlayedS && w >= 645f)
            {
                audioSource.PlayOneShot(videoLecordSE);
                sePlayedS = true;
            }

            if (sePlayedB && !scorePlayedB)
            {
                text.text = "B";
                scorePlayedB = true;
            }


            if (sePlayedB && sePlayedA && !scorePlayedA)
            {
                text.text = "A";
                scorePlayedA = true;
            }

            if (sePlayedB && sePlayedA && sePlayedS && !scorePlayedS)
            {
                text.text = "S";
                scorePlayedS = true;
            }

           
        }
    }

}

