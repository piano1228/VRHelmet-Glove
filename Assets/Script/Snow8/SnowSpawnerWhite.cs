using System.Collections;
using UnityEngine;

public class SnowSpawnerWhite : MonoBehaviour
{
    [SerializeField] private GameObject snowPrefab;
    [SerializeField] private float respawnTime = 3f;

    public void RespawnSnow(Vector3 position, Quaternion rotation)
    {
        StartCoroutine(RespawnCoroutine(position, rotation));
    }

    private IEnumerator RespawnCoroutine(
        Vector3 position,
        Quaternion rotation)
    {
        yield return new WaitForSeconds(respawnTime);

        Instantiate(snowPrefab, position, rotation);
    }
}