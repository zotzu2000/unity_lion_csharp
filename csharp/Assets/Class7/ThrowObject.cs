
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("爆炸效果")]
    public GameObject explosion;

    /// <summary>
    /// 爆炸
    /// </summary>
    private void Explosion()
    {
        // 生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);        // 刪除怪物
        Destroy(exp, 2.5f);         // 2.5 秒後刪除爆炸效果
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "房子")
        {
            Explosion();
        }
    }
}
