using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAutoLoader : MonoBehaviour
{
   // public string nextSceneName; // 移動先のシーン名
    public GameObject maincamera;
   public GameObject VRcamera;

    void Update()
    {
        /* エンターキー（Returnキー）が押されたらシーン遷移
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FadeManager.Instance.LoadScene(nextSceneName, 0.5f);
        }
        */
        

        
       /*if (Input.GetKeyDown(KeyCode.R)){


           VRcamera.transform.position = maincamera.transform.position;
           VRcamera.transform.rotation = maincamera.transform.rotation;

            maincamera.SetActive(false);

        }
       */
        
        


        if (Input.GetKeyDown(KeyCode.V))
        {
            VRcamera.SetActive(true);//VRカメラのDepthの値が大きい
            var switcher = new GameObject("VRModeSwitcher");
            switcher.AddComponent<VRModeSwitcher>().Begin((deviceName) => {
            Debug.Log($"VRモードへの切り替え完了。デバイス名 : {deviceName}");
            Object.Destroy(switcher);
           });
        }



        if (Input.GetKeyDown(KeyCode.N))
        {
            maincamera.SetActive(true);//2DカメラのDepthの値が大きい
            var switcher = new GameObject("NonVRModeSwitcher");
            switcher.AddComponent<NonVRModeSwitcher>().Begin(() => {
            Debug.Log($"非VRモードへの切り替え完了");
            Object.Destroy(switcher);
           });
        }




    }
}
