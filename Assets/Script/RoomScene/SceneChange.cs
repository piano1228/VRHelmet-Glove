using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] string noonTitle;
    [SerializeField] string prologue;
    [SerializeField] string noonRoomScene;
    [SerializeField] string inspectRoomScene;
    [SerializeField] string nightRoomScene;
    [SerializeField] string mvScene;
    [SerializeField] string vrto2D;
    [SerializeField] string result;
    [SerializeField] string ending;
    [SerializeField] string nightTitle;
    [SerializeField] string crosetRoomSceneName;

    [SerializeField] string titleSceneName;
    [SerializeField] string retrySceneName;
    


    public void NoonTitle()
    {
        FadeManager.Instance.LoadScene(noonTitle, 0.5f);
    }

    public void Prologue()
    {
        FadeManager.Instance.LoadScene(prologue, 0.5f);
    }

    public void NoonRoomScene()
    {
        FadeManager.Instance.LoadScene(noonRoomScene, 0.5f);
    }

    public void InspectRoomScene()
    {
        FadeManager.Instance.LoadScene(inspectRoomScene, 0.5f);
    }

    public void NightRoomScene()
    {
        FadeManager.Instance.LoadScene(nightRoomScene, 0.5f);
    }

    public void MVScene()
    {
        FadeManager.Instance.LoadScene(mvScene, 0.5f);
    }

    public void VRto2D()
    {
        FadeManager.Instance.LoadScene(vrto2D, 0.5f);
    }

    public void Result()
    {
        FadeManager.Instance.LoadScene(result, 0.5f);
    }

    public void Ending()
    {
        FadeManager.Instance.LoadScene(ending, 0.5f);
    }


    public void NightTitle()
    {
        FadeManager.Instance.LoadScene(nightTitle, 0.5f);
    }

    public void CrosetRoomScene()
    {
        FadeManager.Instance.LoadScene(crosetRoomSceneName, 0.5f);
    }





    public void TitleScene()
    {
        FadeManager.Instance.LoadScene(titleSceneName, 0.5f);
    }


    public void RetryScene()
    {
        FadeManager.Instance.LoadScene(retrySceneName, 0.5f);
    }


}
