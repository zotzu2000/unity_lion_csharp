using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice6 : MonoBehaviour
{
    //欄位
    //修飾詞 類別 物件名稱
    public SpriteRenderer kid;
    public Rigidbody ball;

    private void Start()
    {
        // 練習 1 : 靜態屬性
        Time.timeScale = 2;

        // 練習 2 : 非靜態屬性
        kid.flipX = true;

        // 練習 3 : 靜態方法
        print(Mathf.Floor(1.23456f));

        // 練習 4 : 非靜態方法
        ball.AddForce(0, 800, 1500);
    }
}
