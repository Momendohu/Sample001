using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Icon : MonoBehaviour {
    //=============================================================
    public int IconNum;
    public Sprite[] sprite;

    private SpriteRenderer spriteRenderer;

    //=============================================================
    private void Init () {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Awake () {
        Init();
    }

    private void Start () {
        if(IconNum >= 0 && IconNum < sprite.Length) {
            spriteRenderer.sprite = sprite[IconNum];
        }
    }

    private void Update () {

    }
}