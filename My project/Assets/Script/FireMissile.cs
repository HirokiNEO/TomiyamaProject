using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    // �ϐ��̒�`�i�f�[�^�����邽�߂̔������j
    public GameObject missilePrefab;
    public float missileSpeed;
    public AudioClip fireSound;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // �v���n�u����~�T�C���I�u�W�F�N�g���쐬���A�����missile�Ƃ������O�̔��ɓ����B
            GameObject missile = Instantiate(missilePrefab, transform.position, Quaternion.identity) as GameObject;

            Rigidbody missileRb = missile.GetComponent<Rigidbody>();

            missileRb.AddForce(transform.forward * missileSpeed);

            AudioSource.PlayClipAtPoint(fireSound, transform.position);

            // ���˂����~�T�C�����Q�b��ɔj��i�폜�j����B
            Destroy(missile, 2.0f);
        }
    }
}