using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private MonoBehaviour mouseLook;
    [SerializeField] private MonoBehaviour playerMove;

    [SerializeField] GameObject converUI;
    [SerializeField] GameObject yukiUI;
    [SerializeField] GameObject noteUI;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject logUI;

    // Update is called once per frame
    void Update()
    {
        
        if (!converUI.activeSelf && !noteUI.activeSelf && !menu.activeSelf && !yukiUI.activeSelf && !logUI.activeSelf)
        {
            mouseLook.enabled = true;
            playerMove.enabled = true;
        }

        if (converUI.activeSelf || noteUI.activeSelf || menu.activeSelf || yukiUI.activeSelf || logUI.activeSelf)
        {
            mouseLook.enabled = false;
            playerMove.enabled = false;
        }

    }
}
