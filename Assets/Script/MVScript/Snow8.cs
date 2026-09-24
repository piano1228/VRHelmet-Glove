using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow8 : MonoBehaviour
{
    [SerializeField] public bool isStart;

    [SerializeField] private float snowInterval;

    [SerializeField] private GameObject lightBlueSnow;
    [SerializeField] private GameObject blueSnow;
    [SerializeField] private GameObject whiteSnow;
    [SerializeField] private GameObject purpleSnow;
    void Update()
    {
        if (isStart)
        {
            StartCoroutine(StartSnow());
        }
    }

    public IEnumerator StartSnow()
    {
        while (true)
        {
            lightBlueSnow.SetActive(true);
            yield return new WaitForSeconds(snowInterval);
            lightBlueSnow.SetActive(false);

            blueSnow.SetActive(true);
            yield return new WaitForSeconds(snowInterval);
            blueSnow.SetActive(false);

            whiteSnow.SetActive(true);
            yield return new WaitForSeconds(snowInterval);
            whiteSnow.SetActive(false);

            purpleSnow.SetActive(true);
            yield return new WaitForSeconds(snowInterval);
            purpleSnow.SetActive(false);
        }
    }

    private void KeyDown()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isStart = true;
        }
    }

}
