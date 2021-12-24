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

    // 変数--------------------------------
    // 各ターゲット
    [SerializeField]
    GameObject[] targets;

    // シーン遷移時の演出
    [SerializeField]
    GameObject fader;

    // ターゲットの数
    [SerializeField]
    int targetNum;

    // ターゲットのHit判定
    bool[] targetHit;

    // 現在の状態
    eSTATE state;

    // Start is called before the first frame update
    void Start()
    {
        // 状態の設定
        state = eSTATE.FADE_IN;

        // 演出用オブジェクトを表示する
        fader.gameObject.SetActive(true);

        // フラグの初期化
        for (int i = 0; i < targetNum; i++)
        {
            targetHit[i] = false;
        }
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
}
