using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject utaUI;
    [SerializeField] private GameObject yukiUI;
    [SerializeField] private GameObject diaUI;
    [SerializeField] private GameObject vrUI;
    [SerializeField] private GameObject logUI;

    public void OpenUtaUI()
    {
        if (utaUI != null)
            utaUI.SetActive(true);
    }

    public void CloseUtaUI()
    {
        if (utaUI != null)
            utaUI.SetActive(false);
    }

    public void OpenYukiUI()
    {
        if (yukiUI != null)
            yukiUI.SetActive(true);
    }

    public void CloseYukiUI()
    {
        if (yukiUI != null)
            yukiUI.SetActive(false);
    }

    public void OpendiaUI()
    {
        if (diaUI != null)
            diaUI.SetActive(true);
    }

    public void ClosediaUI()
    {
        if (diaUI != null)
            diaUI.SetActive(false);
    }

    public void OpenVRUI()
    {
        if (vrUI != null)
            vrUI.SetActive(true);
    }

    public void OpenLogUI()
    {
        if (logUI != null)
            logUI.SetActive(true);
    }

    public void CloseLogUI()
    {
        if (logUI != null)
            logUI.SetActive(false);
    }

}
