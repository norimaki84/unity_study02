﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float speed = 0;
    private Vector2 startPos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    //スワイプの長さを求める
	    if (Input.GetMouseButtonDown(0)) //マウスがクリックされたら
	    {
	        //マウスをクリックした座標
	        this.startPos = Input.mousePosition;
	    }
	    else if(Input.GetMouseButton(0))
	    {
	        //マウスを離した座標
	        Vector2 endPos = Input.mousePosition;
	        float swipeLength = (endPos.x - this.startPos.x);

	        //スワイプの長さを初速度に変換する
	        this.speed = swipeLength / 800.0f;

	        //効果音再生(追加)
	        GetComponent<AudioSource>().Play();
	    }

	    transform.Translate(this.speed, 0, 0); //移動
	    this.speed *= 0.98f;                   //減速
	}
}