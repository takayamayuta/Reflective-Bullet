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
    [SerializeField] GameObject[] targets = new GameObject[TARGET_MAX_NUM];

    // �V�[���J�ڎ��̉��o
    [SerializeField] GameObject fader;

    // ���݂̏��
    eSTATE state;

    // �N���A����
    bool clear;

    // Start is called before the first frame update
    void Start()
    {
        // ��Ԃ̐ݒ�
        state = eSTATE.FADE_IN;

        // ���o�p�I�u�W�F�N�g��\������
        fader.gameObject.SetActive(true);

        // ���N���A���
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
        // �^�[�Q�b�g���S�ł��Ă��邩�m�F���A�S�ł��Ă���Ȃ�N���A�t���O�𗧂Ă�
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
        // �^�[�Q�b�g���������Ă��邩����
        for (int i = 0; i < targets.Length; i++)
        {
            // �^�[�Q�b�g����ł��������Ă���ꍇ�Afalse��Ԃ�
            if (targets[i] != null) return false;
        }

        // �^�[�Q�b�g���S�ł��Ă���ꍇ�Atrue��Ԃ�
        return true;
    }
}
