using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogController : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    private bool isOpen;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                isOpen = !isOpen;

                if (isOpen)
                    uiManager.OpenLogUI();
                else
                    uiManager.CloseLogUI();
            }
        }
    }
