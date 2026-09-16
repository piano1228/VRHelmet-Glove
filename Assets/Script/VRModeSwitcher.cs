using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR;

/// <summary>
/// VRモードへの切り替えを行うクラス
/// </summary>
public class VRModeSwitcher : MonoBehaviour {

  //切り替え後の処理
  private Action<string> _callback;

  //=================================================================================
  //切り替え
  //=================================================================================

  /// <summary>
  /// VRモードへの切り替えを開始
  /// </summary>
  public void Begin(Action<string> callback = null) {
    _callback = callback;
    StartCoroutine(Switch());
  }

  //切り替え
  private IEnumerator Switch() {
    //OpenVRをロードする
    XRSettings.LoadDeviceByName("OpenVR");
    yield return null;
 
    //UnityのXR(VR)を有効にする
    XRSettings.enabled = true;

    //SteamVRが有効になるまで待機
    while (!Valve.VR.SteamVR.enabled) {
      Valve.VR.SteamVR.enabled = true;
      yield return null;
    }
 
    //SteamVRのインスタンスが作られるまで待機
    while (Valve.VR.SteamVR.instance == null) {
      yield return null;
    }

    //接続されているデバイス名をコールバックで返して終了
    _callback?.Invoke(Valve.VR.SteamVR.instance.hmd_TrackingSystemName);
  }

}
