using UnityEngine;

public class CameraMoveConstantForward : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}

