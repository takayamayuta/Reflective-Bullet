using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �萔--------------------------------
    const float ALIVE_TIME = 10.0f;

    // �ϐ�--------------------------------
    Renderer renderer;
    float aliveTimer;   // �������Ԃ��v������^�C�}�[

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        aliveTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // �^�C�}�[�̌v��
        aliveTimer += Time.deltaTime;
        // ��ʊO�ɂ������A�܂��͈�莞�Ԍo�߂����玩�g��j�󂷂�
        //if (!renderer.isVisible || aliveTimer >= ALIVE_TIME) Destroy(gameObject);
        if (!renderer.isVisible)
        {
            Destroy(gameObject);
        }
    }
}
