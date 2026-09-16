using System.Collections;
using UnityEngine;

namespace HI5.VRCalibration
{
    public class CloseState : MonoBehaviour
    {
        [SerializeField] private MenuStateMachine m_MenuSM;
        [SerializeField] private SpriteRenderer m_SpriteRenderer;
        [SerializeField] private MonoBehaviour cameraFoward;//俺が追加した
        [SerializeField] private MonoBehaviour cameraGateFoward;//俺が追加した
        [SerializeField] private GameObject mainCamera;//俺が追加した
        [SerializeField] private GameObject mainCamera2;//俺が追加した

        [SerializeField] private AudioSource audioSource;//俺が追加した
        [SerializeField] private AudioClip music;//俺が追加した

        [SerializeField] private TypewriterTextSpawnerController typewriterTextSpawnerController;//俺が追加した
        [SerializeField] private TestCoruetine testCoruetine;//俺が追加した


        private bool isShowed = false;
        private bool isClosed = false;

        private void OnEnable()
        {
            m_MenuSM.OnStateEnter += HandleStateEnter;
            m_SpriteRenderer.enabled = false;
        }

        private void OnDisable()
        {
            m_MenuSM.OnStateEnter -= HandleStateEnter;
        }

        private void HandleStateEnter(MenuState state)
        {
            if (isShowed && isClosed)
                return;

            if (state == MenuState.Main)
            {
                if (isShowed)
                {
                    m_SpriteRenderer.enabled = false;
                    isClosed = true;
                }
            }

            if (state == MenuState.Exit)
            {
                isShowed = true;
                m_SpriteRenderer.enabled = true;
                StartCoroutine(AutoClose());
            }
        }

        IEnumerator AutoClose()//ここにコルーチンをいれて音楽の再生、カメラの前進、オブジェクトの生成をおこなう。
        {
            yield return new WaitForSeconds(5f);
            m_SpriteRenderer.enabled = false;
            isClosed = true;
            typewriterTextSpawnerController.isStart = true;//俺が追加したテキストの生成
            testCoruetine.isSnowStart = true;//俺が追加した雪の結晶の表示
            mainCamera.SetActive(false);//俺が追加した
            mainCamera2.SetActive(true);//俺が追加した
            cameraFoward.enabled = true;//俺が追加した
            cameraGateFoward.enabled = true;//俺が追加した
            audioSource.PlayOneShot(music);//俺が追加した

        }
    }
}
