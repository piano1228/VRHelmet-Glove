using UnityEngine;

public class PurpleSnow : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;
    [SerializeField] private AudioClip destroySE;
    [SerializeField] private float volume = 0.5f;

    private SnowSpawnerPurple spawner;

    private bool flag = true;

    private void Start()
    {
        spawner = FindObjectOfType<SnowSpawnerPurple>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!flag)
            return;

        flag = false;

        // 接触位置を取得
        Vector3 contactPoint = other.ClosestPoint(transform.position);

        // SE
        if (destroySE != null)
        {
            AudioSource.PlayClipAtPoint(
                destroySE,
                contactPoint,
                volume
            );
        }

        // Spawnerに再生成を依頼
        spawner.RespawnSnow();

        // 雪の結晶を削除
        Destroy(gameObject, 0.001f);
    }
}