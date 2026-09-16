using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicalUIButton : MonoBehaviour
{
    public UnityEvent onPressed;
    public LayerMask Finger;   // ← 追加：Finger レイヤーを指定する

    private void OnTriggerEnter(Collider other)
    {
        // レイヤー判定（Finger レイヤー以外は無視）
        if ((Finger.value & (1 << other.gameObject.layer)) == 0)
            return;

        // Finger レイヤーだった場合のみ発火
        onPressed.Invoke();
    }
}
