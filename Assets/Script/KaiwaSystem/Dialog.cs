using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TMP_Text utaTMP_Text;
    public TMP_Text yukiTMP_Text;
    public TMP_Text diaTMP_Text;
    public TMP_Text text;

    public AudioSource audioSourseMoziokuri;
    public AudioSource audioSource;
    public AudioClip typeSE;
    public AudioClip diaSE;
    public AudioClip keySE;
    public AudioClip hiramekiSE;
    [SerializeField] int SEInterval;

    private bool isTyping;
    private bool isSkip;

    [SerializeField] UIManager uIManager;
    [SerializeField] EventManager eventManager;
    [SerializeField] LogManager logManager;
    [SerializeField] SceneChange sceneChange;


    [SerializeField] string nextSceneName;

    private void Update()
    {
        if (Input.anyKeyDown && isTyping)
        {
            isSkip = true;
        }
    }

    public IEnumerator Conversation(FirstUIController.DialogueLine[] lines)
    {
        foreach (var line in lines)
        {
            if (line.isUta)
            {
                foreach (var sentence in line.text)
                {
                    logManager.Log(sentence);
                    yield return StartCoroutine(UtaConversation(sentence));
                }
            }
            else
            {
                foreach (var sentence in line.text)
                {
                    logManager.Log(sentence);
                    yield return StartCoroutine(YukiConversation(sentence));
                }
            }
        }
    }

    public IEnumerator Conversation1(FirstUIController1.DialogueLine[] lines)
    {
        foreach (var line in lines)
        {
            if (line.isUta)
            {
                foreach (var sentence in line.text)
                {
                    logManager.Log(sentence);
                    yield return StartCoroutine(UtaConversation(sentence));
                }
            }
            else
            {
                foreach (var sentence in line.text)
                {
                    logManager.Log(sentence);
                    yield return StartCoroutine(YukiConversation(sentence));
                }
            }
        }
        FadeManager.Instance.LoadScene(nextSceneName,0.5f);
        //sceneChange.InspectRoomScene();
    }





    public IEnumerator Conversation(UIController.DialogueLine[] lines)
    {
        foreach (var line in lines)
        {

            if (line.isUta)
            {
                foreach (var sentence in line.text)
                {
                    logManager.Log(sentence);
                    yield return StartCoroutine(UtaConversation(sentence));
                }
            }
            else
            {
                foreach (var sentence in line.text)
                {
                    logManager.Log(sentence);
                    yield return StartCoroutine(YukiConversation(sentence));
                }
            }
        }
        eventManager.UnlockCheck();

    }


    public IEnumerator UtaConversation(string text)
    {
        utaTMP_Text.text = "";
        int i=0;
        uIManager.OpenUtaUI();
        yield return new WaitForSeconds(0.01f);
        isTyping = true;

        foreach (char u in text)
        {
            if (isSkip)
            {
                utaTMP_Text.text = text;
                isSkip = false;
                isTyping = false;
                break;
            }

            utaTMP_Text.text += u;
            if (i % SEInterval == 0) audioSourseMoziokuri.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
        }

        isTyping = false;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        yield return new WaitForSeconds(0.01f);
        uIManager.CloseUtaUI();
    }

    public IEnumerator YukiConversation(string text)
    {
        yukiTMP_Text.text = "";
        int i = 0;
        uIManager.OpenYukiUI();
        yield return new WaitForSeconds(0.01f);
        isTyping = true;

        foreach (char y in text)
        {
            if (isSkip)
            {
                yukiTMP_Text.text = text;
                isSkip = false;
                isTyping = false;
                break;
            }

            yukiTMP_Text.text += y;
            if (i % SEInterval == 0) audioSourseMoziokuri.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
        }

        isTyping = false;
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
        yield return new WaitForSeconds(0.01f);
        uIManager.CloseYukiUI();
    }



    public IEnumerator Dia(string letter)
    {
        logManager.Log(letter);

        diaTMP_Text.text = "";
        diaTMP_Text.text = letter;
        audioSource.PlayOneShot(diaSE);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        diaTMP_Text.text = "";
        Debug.Log("E押されました");
        uIManager.ClosediaUI();
        yield return new WaitForSeconds(0.01f);
        eventManager.UnlockCheck();

    }


    public IEnumerator AllDia(string[] letter)
    {

        for (int i = 0; i < letter.Length; i++)
        {
            diaTMP_Text.text = letter[i];
            audioSource.PlayOneShot(diaSE);
            yield return new WaitForSeconds(0.05f);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

            diaTMP_Text.text = "";
        }
        Debug.Log("E押されました");
        uIManager.ClosediaUI();
        yield return new WaitForSeconds(0.01f);
        eventManager.UnlockCheck();
        eventManager.UnlockCheck2();

    }


    public IEnumerator EventLog(string letter)
    {
        logManager.Log(letter);
        yield return new WaitForSeconds(0.1f);
        //audioSource.PlayOneShot(keySE);
        yield return new WaitForSeconds(1f);
        utaTMP_Text.text = "";
       uIManager.OpenUtaUI();

        int i = 0;

        foreach (char a in letter)
        {
            if (isSkip)
            {
                utaTMP_Text.text = letter;
                isSkip = false;
                isTyping = false;
                break;
            }

            utaTMP_Text.text += a;
            if (i % SEInterval == 0) audioSourseMoziokuri.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            isTyping = true;
        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        utaTMP_Text.text = "";
        Debug.Log("E押されました");
        uIManager.CloseUtaUI();
        sceneChange.NightRoomScene();
    }

    public IEnumerator EventLog2(string letter)
    {
        yield return new WaitForSeconds(0.1f);
        audioSource.PlayOneShot(hiramekiSE);
        yield return new WaitForSeconds(1f);
        utaTMP_Text.text = "";
        uIManager.OpenUtaUI();

        int i = 0;

        foreach (char a in letter)
        {
            if (isSkip)
            {
                utaTMP_Text.text = letter;
                isSkip = false;
                isTyping = false;
                break;
            }

            utaTMP_Text.text += a;
            if (i % SEInterval == 0) audioSourseMoziokuri.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            isTyping = true;
        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        utaTMP_Text.text = "";
        Debug.Log("E押されました");
       uIManager.CloseUtaUI();
        uIManager.OpenVRUI();
    }

    public IEnumerator Log(string letter)
    {
        logManager.Log(letter);

        text.text = "";
        int i = 0;

        yield return new WaitForSeconds(0.05f);
        isTyping = true;

        foreach (char a in letter)
        {
            if (isSkip)
            {
                text.text = letter;
                isSkip = false;
                isTyping = false;
                break;
            }

            text.text += a;
            if (i % SEInterval == 0) audioSourseMoziokuri.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);

        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        text.text = "";
        Debug.Log("E押されました");
        uIManager.CloseUtaUI();
        yield return new WaitForSeconds(0.01f);
        eventManager.UnlockCheck();


    }


    public IEnumerator LogAndSceneIdou(string letter)
    {

        text.text = "";
        int i = 0;

        foreach (char a in letter)
        {
            if (isSkip)
            {
                text.text = letter;
                isSkip = false;
                isTyping = false;
                break;
            }

            text.text += a;
            if (i % SEInterval == 0) audioSourseMoziokuri.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            isTyping = true;
        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        text.text = "";
        Debug.Log("E押されました");
        uIManager.CloseUtaUI();
        sceneChange.CrosetRoomScene();



    }


}
