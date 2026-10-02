using UnityEngine;

public class LightBlueSnow : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;
    [SerializeField] private AudioClip destroySE;
    [SerializeField] private float volume = 0.5f;

    private SnowSpawnerLightBlue spawner;

    private bool flag = true;

    private void Start()
    {
        spawner = FindObjectOfType<SnowSpawnerLightBlue>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!flag)
            return;

        flag = false;

        // 接触位置を取得
        Vector3 contactPoint = other.ClosestPoint(transform.position);

        // 雪の結晶エフェクトを生成
        ParticleSystem effect = Instantiate(
            snoweffectPrefab,
            contactPoint,
            Quaternion.identity
        );

        // 生成したエフェクトを0.1秒後に削除
        Destroy(effect.gameObject, 0.1f);

        // Spawnerに再生成を依頼
        spawner.RespawnSnow();

        // 雪の結晶自体を削除
        Destroy(gameObject, 0.001f);
    }
}