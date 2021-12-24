using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // 定数--------------------------------

    // 変数--------------------------------
    bool hit;           // 当たったか判定

    // Start is called before the first frame update
    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Hitフラグを渡す
    public bool GetHit()
    {
        return hit;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 弾と当たったらフラグを立てる
        if (collision.transform.tag == "Bullet")
        {
            hit = true;
        }
    }
}
