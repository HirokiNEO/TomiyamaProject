using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 0.2f;

    // ���ǉ�
    private Vector3 pos;

    void Update()
    {
        // Input�̑O�Ɂu-�v��t����B
        float moveH = Input.GetAxis("Horizontal") * moveSpeed;
        float moveV = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(moveH, 0.0f, moveV);

        // ���ǉ�
        Clamp();
    }

    // ���ǉ�
    // �v���[���[�̈ړ��ł���͈͂𐧌����閽�߃u���b�N
    void Clamp()
    {
        // �v���[���[�̈ʒu�����upos�v�Ƃ������̒��ɓ����B
        pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -10, 10);
        pos.z = Mathf.Clamp(pos.z, -10, 10);

        transform.position = pos;
    }
}