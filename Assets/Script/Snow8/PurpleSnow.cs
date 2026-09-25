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

    private void OnCollisionEnter(Collision collision)
    {
        if (!flag)
            return;

        flag = false;

        ContactPoint contact = collision.contacts[0];

        // SE
        if (destroySE != null)
        {
            AudioSource.PlayClipAtPoint(
                destroySE,
                contact.point,
                volume
            );
        }

        // Spawnerに再生成を依頼
        spawner.RespawnSnow();

        // 雪の結晶を削除
        Destroy(gameObject, 0.001f);
    }
}