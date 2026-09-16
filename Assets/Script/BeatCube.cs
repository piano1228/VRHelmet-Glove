using UnityEngine;

public class BeatCube : MonoBehaviour
{
    public AudioController audioController;             //後にAudioControllerの中のBeatProgress関数を使用するために実装
    public float scaleAmount = 0.3f;

    private Vector3 baseScale;                          //後のscaleを掛ける際にx,y,zすべてのscaleを増加させるためVector3を使用

    void Start()
    {
        baseScale = transform.localScale;               //transform.localScaleはUnityでアタッチされているオブジェクトの現在の大きさを表す Vector3
    }

    void Update()
    {
        float beat = audioController.BeatProgress;      //beatにaudioController内のBeatProgress関数の返り値((PlayingTime / 60.0f * Bpm) % 1.0f)を格納

        float pulse = Mathf.Pow(1f - beat, 2);          //pulseにPow関数を使って1f - beatの値を3乗している。1f - beatは現在の拍の位置

        float scale = 1f + pulse * scaleAmount;         //scaleに1f＋倍率を加算
        transform.localScale = baseScale * scale;       //Cubeのスケール変更1～1.3倍
    }
}