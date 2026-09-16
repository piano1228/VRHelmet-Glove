using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    [SerializeField] private string nextSceneName; // 移動先シーン名

    private void OnTriggerEnter(Collider other)
    {
        // 接触した相手が Player など特定のタグの場合のみ反応させたい場合
        if (other.CompareTag("Result"))
        {
            FadeManager.Instance.LoadScene(nextSceneName, 0.5f);
        }
    }
}

