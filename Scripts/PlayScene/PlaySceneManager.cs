using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneManager : MonoBehaviour
{
    // 定数--------------------------------
    // 状態
    enum eSTATE
    {
        NONE = -1,

        FADE_IN,
        READY,
        PLAY,
        RESULT,
        FADE_OUT,

        MAX
    }

    const int TARGET_MAX_NUM = 10;

    // 変数--------------------------------
    // 各ターゲット
    [SerializeField] GameObject[] targets = new GameObject[TARGET_MAX_NUM];

    // シーン遷移時の演出
    [SerializeField] GameObject fader;

    // 現在の状態
    eSTATE state;

    // クリア判定
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        // 状態の設定
        state = eSTATE.FADE_IN;

        // 演出用オブジェクトを表示する
        fader.gameObject.SetActive(true);

        // 未クリア状態
        clear = false;
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
        {
            case eSTATE.FADE_IN:    FadeIn();   break;
            case eSTATE.READY:      Ready();    break;
            case eSTATE.PLAY:       Play();     break;
            case eSTATE.RESULT:     Result();   break;
            case eSTATE.FADE_OUT:   FadeOut();  break;
        }
    }

    void FadeIn()
    {
        if (fader.GetComponent<Fader>().Fading()) state = eSTATE.READY;
    }

    void Ready()
    {

    }

    void Play()
    {
        // ターゲットが全滅しているか確認し、全滅しているならクリアフラグを立てる
        if (TargetCheck()) clear = true;
    }

    void Result()
    {

    }

    void FadeOut()
    {
        if (fader.GetComponent<Fader>().Fading())
        {

        }
    }

    bool TargetCheck()
    {
        // ターゲットが生存しているか判定
        for (int i = 0; i < targets.Length; i++)
        {
            // ターゲットが一つでも生存している場合、falseを返す
            if (targets[i] != null) return false;
        }

        // ターゲットが全滅している場合、trueを返す
        return true;
    }
}
