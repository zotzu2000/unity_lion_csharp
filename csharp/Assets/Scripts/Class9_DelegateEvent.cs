﻿
using UnityEngine;

public class Class9_DelegateEvent : MonoBehaviour
{
    public void AddTen(int number)
    {
        int n = number += 10;
        print("數字累加 10 : " + n);
    }

    public int number1 = 1;

    private void Awake()
    {
        AddTen(9);
        AddTen(number1);
    }

    public void MethodA()
    {
        print("我是方法 A");
    }

    public void MethodB()
    {
        print("我是方法 B");
    }

    public void MethodC(string msg)
    {
        print("我是方法 C - " + msg);
    }

    // 定義委派
    // 可以儲存 無傳回、無參數 的任何方法
    public delegate void DelegateTest();

    // 可以儲存 無傳回、一個字串參數 的任何方法
    public delegate void DelegateTest2(string s);
    // 定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;

    public DelegateTest2 d2C;

    private void Start()
    {
        dA = MethodA;   // dA 欄位儲存 方法 A
        dA();           // 呼叫 dA

        dB = MethodB;
        dB();

        // dA = MethodC;	// 不同簽名無法儲存
        // dC();

        d2C = MethodC;      // 儲存 方法 C
        d2C("我是委派");
    }
}
