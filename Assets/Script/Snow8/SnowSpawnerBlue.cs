using System.Collections;
using UnityEngine;

public class SnowSpawnerBlue : MonoBehaviour
{
    [SerializeField] private GameObject snowPrefab;
    [SerializeField] private float respawnTime = 3f;

    // 再生成する位置をInspectorから設定
    [SerializeField] private Vector3 respawnPosition;

    // 再生成する回転をInspectorから設定
    [SerializeField] private Vector3 respawnRotation;

    public void RespawnSnow()
    {
        StartCoroutine(RespawnCoroutine());
    }

    private IEnumerator RespawnCoroutine()
    {
        yield return new WaitForSeconds(respawnTime);

        Instantiate(
            snowPrefab,
            respawnPosition,
            Quaternion.Euler(respawnRotation)
        );
    }
}
