using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class IconGenerator : MonoBehaviour {
    //=============================================================
    public GameObject icon;

    //=============================================================
    private void Init () {
    }

    private void Awake () {
        Init();
    }

    private void Start () {
        GenerateObjects(100,5);
    }

    private void Update () {

    }

    //=============================================================
    /// <summary>
    /// オブジェクトを大量生成する
    /// </summary>
    private void GenerateObjects (int num,float range) {
        for(int i = 0;i < num;i++) {
            GenerateObject(new Vector3(Random.Range(-range,range),Random.Range(-range,range),0),(int)Random.Range(0,3));
        }
    }

    //=============================================================
    /// <summary>
    /// オブジェクトを生成する
    /// </summary>
    private void GenerateObject (Vector3 pos,int iconNum) {
        GameObject obj = Instantiate(icon) as GameObject;
        obj.transform.position = pos;
        obj.GetComponent<Icon>().IconNum = iconNum;
    }
}