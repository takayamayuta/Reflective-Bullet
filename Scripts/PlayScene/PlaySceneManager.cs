using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneManager : MonoBehaviour
{
    // �萔--------------------------------
    // ���
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

    // �ϐ�--------------------------------
    // �e�^�[�Q�b�g
    [SerializeField]
    GameObject[] targets = new GameObject[TARGET_MAX_NUM];

    // �V�[���J�ڎ��̉��o
    [SerializeField]
    GameObject fader;

    // �^�[�Q�b�g��Hit����
    bool[] targetHit = new bool[TARGET_MAX_NUM];

    // ���݂̏��
    eSTATE state;

    // Start is called before the first frame update
    void Start()
    {
        // �t���O�̏�����
        for (int i = 0; i < TARGET_MAX_NUM; i++)
        {
            targetHit[i] = false;
        }

        state = eSTATE.FADE_IN;
        // ���o�p�I�u�W�F�N�g��\������
        fader.gameObject.SetActive(true);
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
