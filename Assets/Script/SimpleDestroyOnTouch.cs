using UnityEngine;

public class SimpleDestroyOnTouch : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject,0.01f);
    }
}
