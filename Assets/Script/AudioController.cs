using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource m_AudioSource;
    [SerializeField] float Bpm;

    public float PlayingTime => m_AudioSource.time; //=>は次の式をそのまま返す、という省略記法

    public float BeatProgress
    {
        get         //読み取り専用で値を計算して返せる
        {
            if (Bpm <= 0f)
                return 0f;

            // PlayingTime は秒単位なので、60で割って分単位にし、BPMを掛けて総拍数を計算します。
            // その後、1.0fで剰余を計算することで、現在の拍の進捗 (0.0f～1.0f) を得ます。
            return (PlayingTime / 60.0f * Bpm) % 1.0f;
        }
    }
}