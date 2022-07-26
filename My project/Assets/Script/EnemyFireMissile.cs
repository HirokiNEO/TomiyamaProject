using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMissile : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    public float missileSpeed;
    private int timeCount = 0;

    void Update()
    {
        timeCount += 1;

        // �u%�v�Ɓu==�v�̈Ӗ��𕜏K���܂��傤�I�i�|�C���g�j
        if (timeCount % 60 == 0)
        {
            // �G�̃~�T�C���𐶐�����
            GameObject enemyMissile = Instantiate(enemyMissilePrefab, transform.position, Quaternion.identity);

            Rigidbody enemyMissileRb = enemyMissile.GetComponent<Rigidbody>();

            // �~�T�C�����΂����������߂�B�uforward�v�́uz���v�����������i�|�C���g�j
            enemyMissileRb.AddForce(transform.forward * missileSpeed);

            // �R�b��ɓG�̃~�T�C�����폜����B
            Destroy(enemyMissile, 3.0f);
        }
    }
}