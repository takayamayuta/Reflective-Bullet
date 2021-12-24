using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectSceneManager : MonoBehaviour
{
    // 定数--------------------------------
    public enum eSELECT
    {
        NONE = -1,

        STAGE1,
        STAGE2,
        STAGE3,
        STAGE4,
        STAGE5,

        MAX
    }

    // 変数--------------------------------
    eSELECT select;     // 選択ステージ
    bool moving;        // カメラが動いてる状態

    // Start is called before the first frame update
    void Start()
    {
        // 最初に選択されているステージ
        select = eSELECT.STAGE1;
        // カメラが動いていない状態
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        // ステージを選択
        Select();
    }

    // ステージを選択
    void Select()
    {
        // 右ボタンが押されたら右隣のステージを選択する
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // 選択ステージの変更
            select++;
            // 右隣に選択できるステージがないなら選択ステージの変更をしない
            if (select >= eSELECT.MAX)
            {
                // 一番右のステージを選択している状態にする
                select = eSELECT.MAX - 1;

                return;
            }
            moving = true;
        }
        //左ボタンが押されたら左隣のステージを選択する
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // 選択ステージの変更
            select--;
            // 左隣に選択できるステージがないなら選択ステージの変更をしない
            if (select <= eSELECT.NONE)
            {
                // 一番左のステージを選択している状態にする
                select = eSELECT.NONE + 1;

                return;
            }
            moving = true;
        }
    }

    // カメラが動いている状態か判定フラグを渡す
    public bool GetMoving()
    {
        return moving;
    }

    // 選択しているステージの情報を渡す
    public eSELECT GetSelectStage()
    {
        return select;
    }

    // 移動済
    public void Moved()
    {
        moving = false;
    }
}
