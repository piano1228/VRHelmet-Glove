using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    
    [SerializeField] KidokuManager kidokuManager;
    [SerializeField] GameObject utaUI;
    [SerializeField] GameObject yukiUI;
  //  [SerializeField] GameObject converUI;
    [SerializeField] GameObject diaUI;

    public float rayDistance = 3f;          // Ray の距離
    public LayerMask hitLayers;             // 当たり判定したいレイヤー
    public TestUIManager testUIManager;
    
    void Update()
    {

        // Eキーが押された瞬間
        if (Input.GetKeyDown(KeyCode.E))
        {
            
           if (!utaUI.activeSelf && !yukiUI.activeSelf && !diaUI.activeSelf)
           {
            ShootRay();
           }
           
        }
    }

    void ShootRay()
    {
        // カメラの向きに Ray を飛ばす
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        // Ray を飛ばす
        if (Physics.Raycast(ray, out RaycastHit hit, rayDistance, hitLayers))
        {
            // ObjectTypewriter を持っているかチェック
            TestUIController testUIController = hit.collider.GetComponent<TestUIController>();
            TestDiaUIController testDiaUIController = hit.collider.GetComponent<TestDiaUIController>();
            TestWhichUIController testWhichUIController = hit.collider.GetComponent<TestWhichUIController>();
            UIController uIController = hit.collider.GetComponent<UIController>();

            if (testUIController != null)
            {
                Debug.Log("TestUIController を持っているオブジェクトにヒット: " + hit.collider.name);
               
                // ここに TestUIController の処理を書く

              testUIController.GetText();
              testUIManager.OpenUI();
              kidokuManager.KidokuCheck(testUIController);

            }


            if (testDiaUIController != null)
            {
                Debug.Log("TestDiaUIController を持っているオブジェクトにヒット: " + hit.collider.name);
               
                // ここに TestDiaUIController の処理を書く

               testDiaUIController.GetDiary1();
               testUIManager.OpendiaUI();
               kidokuManager.DiaKidokuCheck(testDiaUIController);
            }

            if (testWhichUIController != null)
            {
                Debug.Log("TestWhichUIController を持っているオブジェクトにヒット: " + hit.collider.name);

                // ここに TestDiaUIController の処理を書く

                testWhichUIController.GetWhichText();
                testUIManager.OpenUI();
                kidokuManager.WicthKidokuCheck(testWhichUIController);
            }

            if (uIController != null)
            {
                Debug.Log("UIController を持っているオブジェクトにヒット: " + hit.collider.name);
                uIController.GetText();
                kidokuManager.KidokuCheck1(uIController);
            }


        }
    }
}