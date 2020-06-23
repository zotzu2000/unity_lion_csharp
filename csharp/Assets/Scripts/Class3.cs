﻿
using UnityEngine;

public class Class3 : MonoBehaviour
{
    // 儲存帶有 Person 類別的物件
    public Person person1;
    public Person person2;
    public void Start()
    {
        // 呼叫 person1 方法 Talk
        person1.Talk();
        person2.Talk();
        // 傳回方法可以直接當作傳回類型使用
        print("屁孩 BMI : " + person1.BMI());
        print("警察 BMI : " + person2.BMI());
        // 使用有參數的方法必須填入對應的引數
        person1.Walk(99, sound: "嘎嘎嘎");
        person2.Walk(10, "左邊");

        person1.Attack();
        person2.Attack("沙漠之鷹");
    }


}
