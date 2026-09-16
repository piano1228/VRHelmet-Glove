using UnityEngine;
using TMPro;
using System.Collections;   //コルーチンを使うため

public class TypewriterTextSpawner : MonoBehaviour
{
    public float delay = 2f;
    public Vector3 offset = new Vector3(0, 2, 5);        //Vector3型であるoffsetに(○, ○, ○)の位置情報を格納している
    public float destroyAfter = 5f;

    [Header("Text Settings")]                            //Inspector上で視認性を上げるため
    public string message = "こんにちは";                //初期設定ではこんにちはを使用
    public TMP_FontAsset fontAsset;                      //fontAssetを使用するためのTMP_FontAsset型fontassetの宣言
    public float fontSize = 5f;
    public VertexGradient colorGradient;                 //上下左右の色を指定できるVertexGradient型の変数colorGradientの宣言

    [Header("Typewriter Settings")]                      //Inspector上で視認性を上げるため
    public float[] intervals;                            // 各文字の表示間隔

    [Header("Pop Animation Settings")]                   //Inspector上で視認性を上げるため
    public float popScale = 1.3f;                        // ポップの強さ（Inspector で調整）
    public float popDuration = 0.08f;                    // 拡大・縮小の時間

    [Header("Move Settings")]                            //Inspector上で視認性を上げるため
    public Vector3 moveDirection = new Vector3(0, 1, 0); //Vector3型であるmoveDirectionに(○, ○, ○)の位置情報を格納している
    public float moveSpeed = 2f;

    void Start()
    {
        Invoke(nameof(SpawnText), delay);                //Invoke(メソッド名, 秒数);で秒数後にメソッドを呼び出すことができる。nameofはSpawnTextのスペルミスがあったとき、この関数は呼ばれることはなくエラーにもならないがnameofをつけるとここでスペルミスをしていることに気づける。（エラーが出る）
    }

    void SpawnText()
    {
        Transform cam = Camera.main.transform;           //Transform型の変数camにメインカメラのtransformを取得している
        Vector3 spawnPos = cam.position + offset;        //Vector3型である変数spawnPosにメインカメラのtransformと設定したVector3型の変数offsetを和算したものを取得している。

        GameObject textObj = new GameObject("TMP_Text");    //textObjに新しく作成した空のオブジェクトTMP_TextをtextObjに格納している
        TextMeshPro tmp = textObj.AddComponent<TextMeshPro>();      //textObjにTextMeshProコンポーネントを追加し、それをTextMeshPro型のtmpに取得させている。

        textObj.transform.position = spawnPos;              //textObjのtransformのpositionをspawnPosの情報にしている
        //textObj.transform.rotation = cam.rotation;          //textObjのtransformのrotationをcamのrotationの情報にしている

        tmp.text = "";
        tmp.font = fontAsset;
        tmp.fontSize = fontSize;
        tmp.colorGradient = colorGradient;
        tmp.enableVertexGradient = true;
        tmp.alignment = TextAlignmentOptions.Center;        //textを中央ぞろえに

        // 動き
      //  MoveTextInDirection mover = textObj.AddComponent<MoveTextInDirection>();    // MoveTextInDirection型の変数moverにtextObjにMoveTextInDirectionコンポーネントを追加したものを格納している
      // mover.direction = moveDirection;    //MoveTextInDirection内の変数directionにmoveDirectionを取得させている
      //  mover.speed = moveSpeed;            //MoveTextInDirection内の変数speedにmoveSpeedを取得させている

        // タイプライター開始
        StartCoroutine(Typewriter(tmp, textObj.transform));     //コルーチン関数Typewriterの開始。tmpはTextMeshPro型、textObj.transformはTransform型。

        Destroy(textObj, destroyAfter);                     //オブジェクトtextObjをdestroyAfter秒後に消滅
    }

    IEnumerator Typewriter(TextMeshPro tmp, Transform textTransform)        //コルーチン関数Typewriterの定義。引数はTextMeshPro型のtmp, Transform型のtextTransform
    {
        char[] chars = message.ToCharArray();   //messageの文字列を1文字ずつの配列に変換している

        for (int i = 0; i < chars.Length; i++)
        {
            tmp.text += chars[i];           //tmpのテキストに分解された文字列を和算していく（Unity上ではここで初めて文字が表示される）

            // ★ 文字が出た瞬間にポップアニメーション
            StartCoroutine(PopAnimation(textTransform));         //コルーチン関数PopAnimationの開始。textTransformはTransform型でなければならない

            float wait = (i < intervals.Length) ? intervals[i] : 0.1f;  //float型の変数waitにiがintervalの配列の要素を超えていなければinterval[i]の値を、そうでなくては0.1fを格納している。
            yield return new WaitForSeconds(wait);                      //wait秒だけ待つ
        }
    }

    IEnumerator PopAnimation(Transform t)       //コルーチン関数PopAnimationの定義。引数はTransform型のt
    {
        Vector3 original = Vector3.one;         //Vector3型の変数originalに(1,1,1)の情報を取得させている。
        Vector3 enlarged = original * popScale; //originalにInsoectorで設定できるpopScaleの値を乗算したものをVector3型の変数enlargedに格納している。

        float tValue = 0;                   //アニメーションの進行度を示す変数。0 → 開始、1 → 終了として Lerp 関数に渡す。

        // 拡大
        while (tValue < 1f) //tValueが1fを超えるまでの処理
        {
            tValue += Time.deltaTime / popDuration; //Time.deltaTime は 前のフレームからの経過時間。popDurationをInspectorで設定することでアニメーションの時間を設定する
            t.localScale = Vector3.Lerp(original, enlarged, tValue);        //original → enlarged に tValue の割合で変化させる
            yield return null;      //コルーチン内で 1フレーム待機 する命令
        }

        // 縮小
        tValue = 0;//tValueをリセット
        while (tValue < 1f)//tValueが1fを超えるまでの処理
        {
            tValue += Time.deltaTime / popDuration;
            t.localScale = Vector3.Lerp(enlarged, original, tValue);//enlarged → original に tValue の割合で変化させる
            yield return null;      //コルーチン内で 1フレーム待機 する命令
        }
    }
}