using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUIManager : MonoBehaviour 
{
    [SerializeField] GameObject converUI;
    [SerializeField] GameObject diaUI;
    [SerializeField] GameObject vrUI;

   public void OpenUI()
   {
       if (converUI != null)
           converUI.SetActive(true);
   }
    
   public void CloseUI()
   {
       if (converUI != null)
           converUI.SetActive(false);
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


}
