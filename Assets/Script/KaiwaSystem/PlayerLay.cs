using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLay : MonoBehaviour
{

    [SerializeField] GameObject utaUI;
    [SerializeField] GameObject yukiUI;


   // [SerializeField] UIController uIController;

    public float rayDistance = 10f;
    public LayerMask hitLayers;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            if (!utaUI.activeSelf && !yukiUI.activeSelf)
            {
                ShootRay();
            }
        }
    }

    void ShootRay()
    {
        // カメラの向きに Ray を飛ばす
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        // Ray を飛ばす
        if (Physics.Raycast(ray, out RaycastHit hit, rayDistance, hitLayers))
        {

            UIController uIController = hit.collider.GetComponent<UIController>();

            if (uIController != null)
            {
                Debug.Log("UIController を持っているオブジェクトにヒット: " + hit.collider.name);
                uIController.GetText();
            }
        }
    }
}
