﻿
using UnityEngine;

// 註解 : 用來說明紀錄等等.. 只會在此腳本內看到
// 摘要 summary : 描述此內容，會在其他腳本內看到 - 提高維護性與擴充性
/// <summary>
/// 
/// </summary>
public class car : MonoBehaviour
{
    // 認識第一個成員 : 欄位 field * 儲存物件資料
    // 資料類型
    // C C 數  - 2000       - 整數 int
    // 重量  - 100.9      - 浮點數 float    
    // 品牌  - BMW        - 字串 string
    // 剎車  -是否開啟    - 布林值 bool  - true 、 false

    // 定義欄位語法 :
    // 資料類型 欄位名稱 (指定 值);
    // 預設值 
    // int 、float為 0
    // string 為 ""
    // bool 為 false
    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;
}
