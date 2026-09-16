using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hi5_Interaction_Core;
using HI5.VRCalibration;
using HI5;

namespace Hi5_Interaction_Interface
{
    public class NoHi5SimpleVibration : MonoBehaviour
    {
        public bool isLeftHand = true;
        public LayerMask hitLayers;// Hi5ObjectGrasp を指定する

        void OnTriggerEnter(Collider other)
        {
            // レイヤー判定
            if ((hitLayers.value & (1 << other.gameObject.layer)) == 0)
                return;

            // 振動
            if (isLeftHand)
            {
                //HI5_Manager.EnableLeftVibration(200);
                TouchCounter.AddTouch();
            }
            else
            {
                //HI5_Manager.EnableRightVibration(200);
                TouchCounter.AddTouch();
            }

        }
    }
}