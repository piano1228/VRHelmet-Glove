using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestDialog : MonoBehaviour
{
    public TMP_Text text;
    public TMP_Text diatext;
    public TestUIManager testUIManager;
    public EventManager eventManager;
    public AudioSource audioSource;
    public AudioClip typeSE;
    public AudioClip diaSE;
    public AudioClip keySE;
    public AudioClip hiramekiSE;
    [SerializeField] int SEinterval;
    [SerializeField] LogManager logManager;



    bool isTyping =false;
    bool skip=false;


    void Update()
    {
        if (Input.anyKeyDown && isTyping){
        skip=true;
        }
    }
    
    
    public IEnumerator Log(string letter)
    {
        
        text.text = "";
        int i=0;

        yield return new WaitForSeconds(0.05f);
        isTyping = true;

        foreach (char a in letter)
        {
            if(skip) {
                text.text=letter;
                skip = false;
                isTyping=false;
                break;
            }

            text.text += a;
            if (i % SEinterval == 0) audioSource.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            
        }
        isTyping=false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
   
        text.text = "";
        Debug.Log("E押されました");
        testUIManager.CloseUI();
        yield return new WaitForSeconds(0.01f);
        eventManager.UnlockCheck();
        

    }
        public IEnumerator Dia(string letter)
    {
        
        text.text = "";
        text.text=letter;
        audioSource.PlayOneShot(diaSE);
        yield return new WaitForSeconds(0.05f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));
   
        text.text = "";
        Debug.Log("E押されました");
        testUIManager.ClosediaUI();
        yield return new WaitForSeconds(0.01f);
        eventManager.UnlockCheck();
        
    }

    public IEnumerator AllDia(string[] letter)
    {
        for (int i = 0; i < letter.Length; i++)
        {
            // text.text = "";
            diatext.text = letter[i];
            audioSource.PlayOneShot(diaSE);
            yield return new WaitForSeconds(0.05f);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

            diatext.text = "";
        }
        Debug.Log("E押されました");
        testUIManager.ClosediaUI();
        yield return new WaitForSeconds(0.01f);
        eventManager.UnlockCheck();
        eventManager.UnlockCheck2();

    }



    public IEnumerator EventLog(string letter)
    {
     //   logManager.Log(letter);

        yield return new WaitForSeconds(0.1f);
        audioSource.PlayOneShot(keySE);
        yield return new WaitForSeconds(1f);
        text.text = "";
        testUIManager.OpenUI();
       
        int i = 0;

        foreach (char a in letter)
        {
            if (skip)
            {
                text.text = letter;
                skip = false;
                isTyping = false;
                break;
            }

            text.text += a;
            if (i % SEinterval == 0) audioSource.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            isTyping = true;
        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        text.text = "";
        Debug.Log("E押されました");
        testUIManager.CloseUI();
    }

    public IEnumerator EventLog2(string letter)
    {
        yield return new WaitForSeconds(0.1f);
        audioSource.PlayOneShot(hiramekiSE);
        yield return new WaitForSeconds(1f);
        text.text = "";
        testUIManager.OpenUI();

        int i = 0;

        foreach (char a in letter)
        {
            if (skip)
            {
                text.text = letter;
                skip = false;
                isTyping = false;
                break;
            }

            text.text += a;
            if (i % SEinterval == 0) audioSource.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            isTyping = true;
        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        text.text = "";
        Debug.Log("E押されました");
        testUIManager.CloseUI();
        testUIManager.OpenVRUI();
    }





    [SerializeField] public SceneChange sceneChange;

    public IEnumerator LogAndSceneIdou(string letter)
    {

        text.text = "";
        int i = 0;

        foreach (char a in letter)
        {
            if (skip)
            {
                text.text = letter;
                skip = false;
                isTyping = false;
                break;
            }

            text.text += a;
            if (i % SEinterval == 0) audioSource.PlayOneShot(typeSE);
            i++;
            yield return new WaitForSeconds(0.05f);
            isTyping = true;
        }
        isTyping = false;
        yield return new WaitForSeconds(0.01f);
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E));

        text.text = "";
        Debug.Log("E押されました");
        testUIManager.CloseUI();
        sceneChange.CrosetRoomScene();

       

    }

}