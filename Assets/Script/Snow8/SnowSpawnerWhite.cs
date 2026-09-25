using System.Collections;
using UnityEngine;

public class SnowSpawnerWhite : MonoBehaviour
{
    [SerializeField] private GameObject snowPrefab;
    [SerializeField] private float respawnTime = 3f;

    // Inspectorから再生成位置を指定
    [SerializeField] private Vector3 respawnPosition;

    // Inspectorから再生成時の回転を指定
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