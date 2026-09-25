using UnityEngine;

public class BlueSnow : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;
    [SerializeField] private AudioClip destroySE;
    [SerializeField] private float volume = 0.5f;

    private SnowSpawnerBlue spawner;

    private void Start()
    {
        spawner = FindObjectOfType<SnowSpawnerBlue>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Spawnerに再生成を依頼
        spawner.RespawnSnow();

        // 雪の結晶を削除
        Destroy(gameObject);
    }
}