using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // �萔--------------------------------

    // �ϐ�--------------------------------
    bool hit;           // ��������������

    // Start is called before the first frame update
    void Start()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Hit�t���O��n��
    public bool GetHit()
    {
        return hit;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �e�Ɠ���������t���O�𗧂Ă�
        if (collision.transform.tag == "Bullet")
        {
            hit = true;
        }
    }
}
