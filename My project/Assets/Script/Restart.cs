using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���i�ǉ��j
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // ���i�ǉ��j
    // �擪�Ɂupublic�v�����邱�Ɓi�|�C���g�j
    public void OnRestartButtonClicked()
    {
        SceneManager.LoadScene("Main");
    }
}