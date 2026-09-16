using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoruetine : MonoBehaviour
{
    [SerializeField] public bool isSnowStart;

    [SerializeField] private float snowInterval;


    [SerializeField] private GameObject lightBlueSnow1;
    [SerializeField] private GameObject lightBlueSnow2;
    [SerializeField] private GameObject lightBlueSnow3;
    [SerializeField] private GameObject lightBlueSnow4;
    [SerializeField] private GameObject lightBlueSnow5;
    [SerializeField] private GameObject lightBlueSnow6;
    [SerializeField] private GameObject lightBlueSnow7;
    [SerializeField] private GameObject lightBlueSnow8;


    //  [SerializeField] private float lightBluetoBlue;


    [SerializeField] private GameObject blueSnow1;
    [SerializeField] private GameObject blueSnow2;
    [SerializeField] private GameObject blueSnow3;
    [SerializeField] private GameObject blueSnow4;
    [SerializeField] private GameObject blueSnow5;
    [SerializeField] private GameObject blueSnow6;
    [SerializeField] private GameObject blueSnow7;
    [SerializeField] private GameObject blueSnow8;


    // [SerializeField] private float bluetoWhite;


    [SerializeField] private GameObject whiteSnow1;
    [SerializeField] private GameObject whiteSnow2;
    [SerializeField] private GameObject whiteSnow3;
    [SerializeField] private GameObject whiteSnow4;
    [SerializeField] private GameObject whiteSnow5;
    [SerializeField] private GameObject whiteSnow6;
    [SerializeField] private GameObject whiteSnow7;
    [SerializeField] private GameObject whiteSnow8;


    // [SerializeField] private float whitetoPurple;


    [SerializeField] private GameObject purpleSnow1;
    [SerializeField] private GameObject purpleSnow2;
    [SerializeField] private GameObject purpleSnow3;
    [SerializeField] private GameObject purpleSnow4;
    [SerializeField] private GameObject purpleSnow5;
    [SerializeField] private GameObject purpleSnow6;
    [SerializeField] private GameObject purpleSnow7;
    [SerializeField] private GameObject purpleSnow8;



    void Update()
    {
        if (isSnowStart)
        {
            StartCoroutine(StartSnow());
            isSnowStart = false;
            Debug.Log("isSnowStart="+isSnowStart);
        }
    }

    public IEnumerator StartSnow()
    {
        lightBlueSnow1.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow2.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow3.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow4.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow5.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow6.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow7.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        lightBlueSnow8.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        //  yield return new WaitForSeconds(lightBluetoBlue);

        blueSnow1.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow2.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow3.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow4.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow5.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow6.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow7.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        blueSnow8.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        //  yield return new WaitForSeconds(bluetoWhite);

        whiteSnow1.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow2.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow3.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow4.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow5.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow6.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow7.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        whiteSnow8.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        //   yield return new WaitForSeconds(whitetoPurple);

        purpleSnow1.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow2.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow3.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow4.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow5.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow6.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow7.SetActive(true);
        yield return new WaitForSeconds(snowInterval);

        purpleSnow8.SetActive(true);
       // yield return new WaitForSeconds(snowInterval);

    }
}
