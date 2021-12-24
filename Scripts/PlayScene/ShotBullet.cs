using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBullet : MonoBehaviour
{
    // �萔--------------------------------
    const float BULLET_SPEED = 3.0f;

    // �ϐ�--------------------------------
    [SerializeField]
    GameObject bulletPrefab;        // ���˂���e

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���N���b�N���ꂽ��
        if (Input.GetMouseButtonDown(0))
        {
            // ��̃I�u�W�F�N�g�𐶐�
            GameObject go = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            // �N���b�N�������W�̎擾
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // �����̐���
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 1, 0)).normalized;
            // �e�ɑ��x��^����
            go.GetComponent<Rigidbody2D>().velocity = shotForward * BULLET_SPEED;
        }
    }
}
