using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidokuManager : MonoBehaviour
{
    public int checkedcount=0;


    public void KidokuCheck(TestUIController testUIController) 
    {
        if(!testUIController.isChecked)
        {
            testUIController.isChecked = true;
            checkedcount++;

            Debug.Log("既読数：" + checkedcount);

        }
    }


    

    public void KidokuCheck1(UIController uIController)
    {
        if (!uIController.isChecked)
        {
            uIController.isChecked = true;
            checkedcount++;

            Debug.Log("既読数：" + checkedcount);

        }
    }


    public void DiaKidokuCheck(TestDiaUIController testDiaUIController)
    {
        if (!testDiaUIController.isChecked)
        {
            testDiaUIController.isChecked = true;
            checkedcount++;

            Debug.Log("既読数：" + checkedcount);

        }
    }

    public void WicthKidokuCheck(TestWhichUIController testWhichUIController)
    {
        if (!testWhichUIController.isChecked)
        {
            testWhichUIController.isChecked = true;
            checkedcount++;

            Debug.Log("既読数：" + checkedcount);

        }
    }


}
