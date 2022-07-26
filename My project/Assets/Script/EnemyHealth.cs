using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip destroySound;
    public int enemyHP;
    private Slider slider;
    // �����ǉ��i�X�R�A�j
    public int scoreValue;
    private ScoreManager sm;

    void Start()
    {
        slider = GameObject.Find("EnemyHPSlider").GetComponent<Slider>();
        slider.maxValue = enemyHP;
        slider.value = enemyHP;

        // �����ǉ��i�X�R�A�j
        // �uScoreLabel�v�I�u�W�F�N�g�ɂ��Ă���uScoreManager�v�X�N���v�g�ɃA�N�Z�X���Ď擾����i�|�C���g�j
        sm = GameObject.Find("ScoreLabel").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Missile"))
        {
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            enemyHP -= 1;
            slider.value = enemyHP;
            Destroy(other.gameObject);

            if (enemyHP == 0)
            {
                Destroy(transform.root.gameObject);
                AudioSource.PlayClipAtPoint(destroySound, transform.position);

                // �����ǉ��i�X�R�A�j
                // �G��j�󂵂��u�ԂɃX�R�A�����Z���郁�\�b�h���Ăяo���B
                // �����ɂ́uscoreValue�v������B
                sm.AddScore(scoreValue);
            }
        }
    }
}