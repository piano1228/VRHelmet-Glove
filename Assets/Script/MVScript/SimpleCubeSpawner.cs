using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCubeSpawner : MonoBehaviour
{
    public float delay = 3f;                 // 何秒後に生成するか
    public Vector3 offset = new Vector3(0, 0, 5); // カメラからの相対位置
    public float destroyAfter = 5f;          // 生成したオブジェクトを何秒後に消すか
    public Transform parentObject;

    void Start()
    {
        Invoke(nameof(SpawnCube), delay);
    }

    void SpawnCube()
    {
        // MainCamera の Transform を取得
        Transform cam = Camera.main.transform;

        // 生成位置
        Vector3 spawnPos = cam.position + offset;

        // Cube を生成（Prefab 不要）
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = spawnPos;

        cube.layer = LayerMask.NameToLayer("Hi5ObjectGrasp");

         Rigidbody rb = cube.AddComponent<Rigidbody>();
         rb.useGravity = false;

         if (parentObject != null)
        cube.transform.parent = parentObject;

        // 指定秒数後に自動で削除
        Destroy(cube, destroyAfter);
    }
}

