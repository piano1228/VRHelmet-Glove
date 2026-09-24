using UnityEngine;
public class WhiteSnow : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;
    [SerializeField] private AudioClip destroySE;
    [SerializeField] private float volume = 0.5f;

    private SnowSpawnerWhite spawner;

    private bool flag = true;

    private void Start()
    {
        spawner = FindObjectOfType<SnowSpawnerWhite>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!flag)
            return;

        flag = false;

        ContactPoint contact = collision.contacts[0];

        // 雪の結晶エフェクトを生成
        ParticleSystem effect = Instantiate(
            snoweffectPrefab,
            contact.point,
            Quaternion.identity
        );

        // 生成したエフェクトを0.1秒後に削除
        Destroy(effect.gameObject, 0.1f);

        // SE
        if (destroySE != null)
        {
            AudioSource.PlayClipAtPoint(
                destroySE,
                contact.point,
                volume
            );
        }

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