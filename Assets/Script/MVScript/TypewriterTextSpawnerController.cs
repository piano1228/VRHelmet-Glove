using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypewriterTextSpawnerController : MonoBehaviour
{
    public bool isStart = false;

    [SerializeField] private MonoBehaviour lyric1;
    [SerializeField] private float time1;

    [SerializeField] private MonoBehaviour lyric2;
    [SerializeField] private float time2;

    [SerializeField] private MonoBehaviour lyric3;
    [SerializeField] private float time3;

    [SerializeField] private MonoBehaviour lyric4;
    [SerializeField] private float time4;

    [SerializeField] private MonoBehaviour lyric5;
    [SerializeField] private float time5;

    [SerializeField] private MonoBehaviour lyric6;
    [SerializeField] private float time6;

    [SerializeField] private MonoBehaviour lyric7;
    [SerializeField] private float time7;

    [SerializeField] private MonoBehaviour lyric8;
    [SerializeField] private float time8;

    [SerializeField] private MonoBehaviour lyric9;
    [SerializeField] private float time9;

    [SerializeField] private MonoBehaviour lyric10;
    [SerializeField] private float time10;

    [SerializeField] private MonoBehaviour lyric11;
    [SerializeField] private float time11;

    [SerializeField] private MonoBehaviour lyric12;
    [SerializeField] private float time12;

    [SerializeField] private MonoBehaviour lyric13;
    [SerializeField] private float time13;

    [SerializeField] private MonoBehaviour lyric14;
    [SerializeField] private float time14;

    [SerializeField] private MonoBehaviour lyric15;
    [SerializeField] private float time15;

    [SerializeField] private MonoBehaviour lyric16;
    [SerializeField] private float time16;

    [SerializeField] private MonoBehaviour lyric17;
    [SerializeField] private float time17;

    [SerializeField] private MonoBehaviour lyric18;
    [SerializeField] private float time18;

    [SerializeField] private MonoBehaviour lyric19;
    [SerializeField] private float time19;

    [SerializeField] private MonoBehaviour lyric20;
    [SerializeField] private float time20;

    [SerializeField] private MonoBehaviour lyric21;
    [SerializeField] private float time21;

    [SerializeField] private MonoBehaviour lyric22;
    [SerializeField] private float time22;

    [SerializeField] private MonoBehaviour lyric23;
    [SerializeField] private float time23;

    [SerializeField] private MonoBehaviour lyric24;
    [SerializeField] private float time24;

    [SerializeField] private MonoBehaviour lyric25;
   // [SerializeField] private float time25;





    //void Start()
    //{
    //    StartCoroutine(StartSpawmn());
    //}
    void Update()
    {
        if (isStart)
        {
            StartCoroutine(StartSpawmn());
            isStart = false;
            Debug.Log("isStart="+isStart);
        }
    }

    private IEnumerator StartSpawmn()
    {
        lyric1.enabled = true;
        yield return new WaitForSeconds(time1);
        lyric2.enabled = true;
        yield return new WaitForSeconds(time2);
        lyric3.enabled = true;
        yield return new WaitForSeconds(time3);
        lyric4.enabled = true; 
        yield return new WaitForSeconds(time4);
        lyric5.enabled = true; 
        yield return new WaitForSeconds(time5);
        lyric6.enabled = true; 
        yield return new WaitForSeconds(time6);
        lyric7.enabled = true;
        yield return new WaitForSeconds(time7);
        lyric8.enabled = true;
        yield return new WaitForSeconds(time8);
        lyric9.enabled = true;
        yield return new WaitForSeconds(time9);
        lyric10.enabled = true;
        yield return new WaitForSeconds(time10);
        lyric11.enabled = true;
        yield return new WaitForSeconds(time11);
        lyric12.enabled = true;
        yield return new WaitForSeconds(time12);
        lyric13.enabled = true;
        yield return new WaitForSeconds(time13);
        lyric14.enabled = true;
        yield return new WaitForSeconds(time14);
        lyric15.enabled = true;
        yield return new WaitForSeconds(time15);
        lyric16.enabled = true;
        yield return new WaitForSeconds(time16);
        lyric17.enabled = true;
        yield return new WaitForSeconds(time17);
        lyric18.enabled = true;
        yield return new WaitForSeconds(time18);
        lyric19.enabled = true;
        yield return new WaitForSeconds(time19);
        lyric20.enabled = true;
        yield return new WaitForSeconds(time20);
        lyric21.enabled = true;
        yield return new WaitForSeconds(time21);
        lyric22.enabled = true;
        yield return new WaitForSeconds(time22);
        lyric23.enabled = true;
        yield return new WaitForSeconds(time23);
        lyric24.enabled = true;
        yield return new WaitForSeconds(time24);
        lyric25.enabled = true;
        
    }

}
