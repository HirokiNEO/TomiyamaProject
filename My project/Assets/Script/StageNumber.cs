using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���ǉ�
using UnityEngine.UI;

public class StageNumber : MonoBehaviour
{
    // ���ǉ�
    private Text stageNumberText;

    void Start()
    {
        // ���ǉ�
        // �uText�v�R���|�[�l���g�ɃA�N�Z�X���Ď擾����B
        stageNumberText = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        // ���ǉ�
        stageNumberText.color = Color.Lerp(stageNumberText.color, new Color(1, 1, 1, 0), 0.5f * Time.deltaTime);
    }
}