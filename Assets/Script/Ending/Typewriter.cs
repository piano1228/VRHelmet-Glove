using TMPro;
using UnityEngine;
using System.Collections;

public class Typewriter : MonoBehaviour
{
    public TMP_Text tmp;
    public GameObject entertmp;
    [TextArea] public string fullText;
    public float interval = 0.05f;
    public float lineBreakWait = 0.5f;   // Å© â¸çsÇ≈é~ÇﬂÇÈéûä‘
    [SerializeField] int SEinterval;
    public AudioSource audioSourceMoziokuri;
    public AudioSource audioSource;
    public AudioClip typeSE;

    void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        tmp.text = fullText;
        tmp.maxVisibleCharacters = 0;

        int total = fullText.Length;

        for (int i = 0; i < total; i++)
        {
            tmp.maxVisibleCharacters = i;

            // SE çƒê∂
            if (i>0 && typeSE != null && audioSource != null)
            {
                if (i % SEinterval == 0) audioSourceMoziokuri.PlayOneShot(typeSE);
            }

            // Åö â¸çsÇ»ÇÁí«â¡Ç≈ë“Ç¬
            if (i > 0 && fullText[i-1] == 'ÅB')
            {
                yield return new WaitForSeconds(lineBreakWait);
            }

            if (i>=total-1)
            {
                yield return new WaitForSeconds(lineBreakWait);
                entertmp.SetActive(true);
            }



            yield return new WaitForSeconds(interval);
        }


    }
}