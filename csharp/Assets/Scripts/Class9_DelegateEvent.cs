
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
}
