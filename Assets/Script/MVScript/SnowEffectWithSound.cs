using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowEffectWithSound : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;

    public AudioClip destroySE;
    public AudioSource audioSource;
    public float volume=0.5f;

    private bool flag = true;

    private void OnCollisionEnter(Collision collision)
    {
       // if (collision.gameObject.CompareTag("Hand"))
      //  {
            if (this.flag)
            {
                flag = false;

                Debug.Log("エフェクト再生するにょーん");
                ContactPoint contact = collision.contacts[0];

                ParticleSystem effect = Instantiate(
                    snoweffectPrefab,
                    contact.point,
                    Quaternion.identity
                );

                if (destroySE != null)
                {
                    audioSource.PlayOneShot(destroySE, volume);  // 音量指定
                    Debug.Log("音出したにょーん");
                }

                Destroy(effect.gameObject, 0.1f);//雪の結晶のエフェクトを消す
                Destroy(gameObject, 0.001f);//雪の結晶自体を消す
            }
      //  }
    }
}
