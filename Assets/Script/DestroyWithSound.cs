using UnityEngine;

public class DestroyWithSound : MonoBehaviour
{
    public AudioClip destroySE; 
    public AudioSource audioSource;
    public float volume = 0.5f;   // 音量調整変数

    private bool flag=true;

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Hand"))
        //{
            if (this.flag)//連続して音が鳴ったりエフェクトが再生されるのを防ぐため
            {
                flag = false;

                if (destroySE != null)
                {
                    audioSource.PlayOneShot(destroySE, volume);  // 音量指定
                    Debug.Log("音出したにょーん");

                }
                Destroy(gameObject, 0.001f);
            }
        //}
    }
}

