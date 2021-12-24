using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectSceneManager : MonoBehaviour
{
    // �萔--------------------------------
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

    // �ϐ�--------------------------------
    eSELECT select;     // �I���X�e�[�W
    bool moving;        // �J�����������Ă���

    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��ɑI������Ă���X�e�[�W
        select = eSELECT.STAGE1;
        // �J�����������Ă��Ȃ����
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        // �X�e�[�W��I��
        Select();
    }

    // �X�e�[�W��I��
    void Select()
    {
        // �E�{�^���������ꂽ��E�ׂ̃X�e�[�W��I������
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // �I���X�e�[�W�̕ύX
            select++;
            // �E�ׂɑI���ł���X�e�[�W���Ȃ��Ȃ�I���X�e�[�W�̕ύX�����Ȃ�
            if (select >= eSELECT.MAX)
            {
                // ��ԉE�̃X�e�[�W��I�����Ă����Ԃɂ���
                select = eSELECT.MAX - 1;

                return;
            }
            moving = true;
        }
        //���{�^���������ꂽ�獶�ׂ̃X�e�[�W��I������
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // �I���X�e�[�W�̕ύX
            select--;
            // ���ׂɑI���ł���X�e�[�W���Ȃ��Ȃ�I���X�e�[�W�̕ύX�����Ȃ�
            if (select <= eSELECT.NONE)
            {
                // ��ԍ��̃X�e�[�W��I�����Ă����Ԃɂ���
                select = eSELECT.NONE + 1;

                return;
            }
            moving = true;
        }
    }

    // �J�����������Ă����Ԃ�����t���O��n��
    public bool GetMoving()
    {
        return moving;
    }

    // �I�����Ă���X�e�[�W�̏���n��
    public eSELECT GetSelectStage()
    {
        return select;
    }

    // �ړ���
    public void Moved()
    {
        moving = false;
    }
}
