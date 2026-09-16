using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySnowFlake : MonoBehaviour
{
    private bool flag=true;

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("Hand"))
        //{
            if (this.flag)
            {
                flag = false;

                Destroy(gameObject, 0.001f);                //雪の結晶自体を消す
            }
       // }
    }
}
