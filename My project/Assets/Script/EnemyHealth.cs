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
    // ★★追加（スコア）
    public int scoreValue;
    private ScoreManager sm;

    void Start()
    {
        slider = GameObject.Find("EnemyHPSlider").GetComponent<Slider>();
        slider.maxValue = enemyHP;
        slider.value = enemyHP;

        // ★★追加（スコア）
        // 「ScoreLabel」オブジェクトについている「ScoreManager」スクリプトにアクセスして取得する（ポイント）
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

                // ★★追加（スコア）
                // 敵を破壊した瞬間にスコアを加算するメソッドを呼び出す。
                // 引数には「scoreValue」を入れる。
                sm.AddScore(scoreValue);
            }
        }
    }
}