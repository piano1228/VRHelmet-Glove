using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntertoScene : MonoBehaviour
{
    public string nextSceneName;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            FadeManager.Instance.LoadScene(nextSceneName, 0.5f);
            
        }
    }
}