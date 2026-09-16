using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem snoweffectPrefab;
   // [SerializeField] private MonoBehaviour snowehhect;
    private bool flag = true;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("aaaa");
        //if (collision.gameObject.CompareTag("Hand"))
       // {
            if (this.flag)
            {
                flag = false;
                ContactPoint contact = collision.contacts[0];   //1番最初に触れた設置点の取得

                ParticleSystem effect = Instantiate(    //オブジェクトの生成
                    snoweffectPrefab,
                    contact.point,
                    Quaternion.identity
                );

                // snowehhect.enabled = false;

                Destroy(effect.gameObject, 0.1f);         //雪の結晶のエフェクトを消す
                Destroy(gameObject, 0.001f);                //雪の結晶自体を消す
            }
        //}
    }
}
