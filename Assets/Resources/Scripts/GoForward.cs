using HI5.VRInteraction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HI5.VRInteraction
{
    public class GoForward : MonoBehaviour
    {
        public GameObject UnLockMoveObj = GameObject.Find("UnlockMove");
        public GameObject lockMoveObj = GameObject.Find("LockMove");
        [SerializeField] protected SelectionRadial m_selectionRadial;
        [SerializeField] protected VRInteractiveItem m_InteractiveItem;
        protected bool m_GazeOver;

        protected void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;

            m_GazeOver = false;

            m_selectionRadial.OnSelectionComplete += HandleSelectionComplete;
        }
        protected void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
            m_selectionRadial.OnSelectionComplete -= HandleSelectionComplete;
        }
        // Start is called before the first frame update

        private void Start()
        {
            UnLockMoveObj.SetActive(false);
            lockMoveObj.SetActive(false);
        }
        // Update is called once per frame

        protected void HandleOver()
        {
            m_selectionRadial.Show();
            m_GazeOver = true;
        }
        protected void HandleOut()
        {
            m_selectionRadial.Hide();
            m_GazeOver = false;
        }
        private void HandleSelectionComplete()
        {
            if (m_GazeOver)
            {
                UnLockMoveObj.SetActive(true);
                lockMoveObj.SetActive(true);
                //GameObject maincamera = GameObject.Find("Main Camera");
                //GameObject vrMan = GameObject.Find("[CameraRig]_HI5_Interaction");

                // maincamera.transform.position+= 
            }
        }

    }
}