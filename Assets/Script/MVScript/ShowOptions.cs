using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowOptions : MonoBehaviour
{
    public GameObject continueImage;
    public GameObject retryImage;
    public GameObject quitImage;

    public void Show()
    {
        continueImage.SetActive(true);
        retryImage.SetActive(true);
        quitImage.SetActive(true);
    }

    public void HideOptions()
{
    continueImage.SetActive(false);
    retryImage.SetActive(false);
    quitImage.SetActive(false);
}



public void Retry()
{   
   
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     continueImage.SetActive(false);
    retryImage.SetActive(false);
    quitImage.SetActive(false);
}

public void QuitGame()
{   
    Application.Quit();
     continueImage.SetActive(false);
    retryImage.SetActive(false);
    quitImage.SetActive(false);
}




}



