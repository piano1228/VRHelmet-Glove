using UnityEngine;
public class BlueSnow : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;
    [SerializeField] private AudioClip destroySE;
    [SerializeField] private float volume = 0.5f;

    private SnowSpawnerBlue spawner;

    private bool flag = true;

    private void Start()
    {
        spawner = FindObjectOfType<SnowSpawnerBlue>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Destroy前に位置・回転を保存
        Vector3 spawnPosition = transform.position;
        Quaternion spawnRotation = transform.rotation;

        // Spawnerに再生成を依頼
        spawner.RespawnSnow(
            spawnPosition,
            spawnRotation
        );

        // 雪の結晶自体を削除
        Destroy(gameObject, 0.001f);
    }
}