using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    [SerializeField] GameObject menu;
    [SerializeField] SceneChange scenechange;
    [SerializeField] GameObject audioSourse;

    public void OnClickButtonMenu()
    {
        if (!menu.activeSelf)
            menu.SetActive(true);
        else
        {
            menu.SetActive(false);
        }
    }

    public void OnClickButtonRetry()
    {
        menu.SetActive(false);
        scenechange.RetryScene();

    }

    public void OnClickButtonContinue()
    {
        menu.SetActive(false);
    }

    public void OnClickButtonTitle()
    {
        menu.SetActive(false);
        scenechange.TitleScene();
    }

    public void LustOnClickButtonTitle()
    {
        SceneManager.MoveGameObjectToScene(audioSourse, SceneManager.GetActiveScene());
        menu.SetActive(false);
        scenechange.TitleScene();
    }

}
