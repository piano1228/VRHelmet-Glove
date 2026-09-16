using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // A/D or ←/→
        float v = Input.GetAxis("Vertical");   // W/S or ↑/↓

        Vector3 move = new Vector3(h, 0, v);

        transform.Translate(move * speed * Time.deltaTime, Space.Self);
    }
}
