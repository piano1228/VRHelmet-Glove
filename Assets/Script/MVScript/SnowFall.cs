using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFall : MonoBehaviour
{

    [SerializeField] float speed;

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
    }
}

