using UnityEngine;

public class Class6_StaticAPI : MonoBehaviour
{
    //物件
    public Enemy zombie1, zombie2;

    private void Start()
    {
        #region 靜態練習
        //一般欄位
        //取得方式 : 物件.欄位
        print(zombie1.name + "血量 :" + zombie1.hp);
        print(zombie2.name + "血量 :" + zombie2.hp);

        //靜態欄位
        //取得方式 : 類別.靜態欄位
        print("殭屍的速度 : " + Enemy.speed);

        //無法透過物件取得靜態欄位 (錯誤)
        //print(zombie1.speed);

        //使用一般方法
        //物件.方法
        zombie1.Walk();
        zombie2.Walk();

        //使用靜態方法
        //類別.靜態方法
        Enemy.Stop();

        //無法透過物件取得靜態方法 (錯誤)
        //zombie1.Stop();
        #endregion

        //API 靜態成員

        //存放 靜態 屬性
        //類別.靜態屬性 = 值
        Cursor.visible = false;

        //取得靜態屬性
        print(Mathf.PI);

        //取得 隨機.值
        print(Random.value);

        //使用靜態方法
        //類別.靜態方法 (對應的引數)
        print("絕對值 : " + Mathf.Abs(-77.7f));

        print("隨機範圍 : " + Random.Range(1f, 100f));

        //整數不傳回最大值
        print("隨機整數 : " + Random.Range(1, 3));
    }

    //偵測玩家輸入 - 約 60 FPS
    private void Update()
    {
        //原本用法 : 字串
        print("玩家是否按空白鍵 : " + Input.GetKeyDown("space"));
        //多載 1 : 列舉
        print("玩家是否按右鍵 : " + Input.GetKeyDown(KeyCode.Mouse1));
    }
}
