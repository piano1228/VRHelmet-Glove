using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensitivity = 200f;                                      //マウス感度
    float xRotation = 0f;

    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;                                 // マウスカーソルを画面中央に固定クリックするとカーソルが消えてしまうためコメントアウトしている。
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;     //マウスの左右移動量を取得
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;     //マウスの上下移動量を取得

        // 上下の回転（カメラ）
        xRotation -= mouseY;                                                        //Unityの座標系では上方向は「X軸の負方向」なので、xRotation -= mouseY で自然な上下動になる。
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);                              //Mathf.Clampは値を範囲内に収める関数。上下に完全に回転させるとカメラが後ろに反転してしまうため、実装
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);              //transform.localRotationはオブジェクトの親に対する相対的な回転。Quaternion.Euler(xRotation, 0f, 0f)はX軸回転だけを設定

        // 左右の回転（プレイヤー本体）
        transform.parent.Rotate(Vector3.up * mouseX);                               //parent(親)オブジェクトのRotateをY軸方向（垂直軸）で回転。
    }
}
