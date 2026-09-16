using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

/// <summary>
/// 非VRモードへの切り替えを行うクラス
/// </summary>
public class NonVRModeSwitcher : MonoBehaviour {

  //切り替え後の処理
  private Action _callback;

  //=================================================================================
  //切り替え
  //=================================================================================

  /// <summary>
  /// 非VRモードへの切り替えを開始
  /// </summary>
  public void Begin(Action callback = null) {
    _callback = callback;
    StartCoroutine(Switch());
  }

  //切り替え
  private IEnumerator Switch() {
    //Noneをロードする
    XRSettings.LoadDeviceByName("None");
    yield return null;
 
    //UnityのXR(VR)設定を無効にする
    XRSettings.enabled = false;

    //SteamVRが無効になるまで待機
    while (Valve.VR.SteamVR.enabled) {
      Valve.VR.SteamVR.enabled = false;
      yield return null;
    }
 
    //コールバックを実行して終了
    _callback?.Invoke();
  }

}
