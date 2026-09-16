using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonDestroyer : MonoBehaviour
{
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
