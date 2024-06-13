using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // �� �ε����� �޾Ƽ� ���� ��ȯ�ϴ� �޼ҵ�
    public void LoadSceneByIndex(int sceneIndex)
    {
        // ���� ���ÿ��� ��ϵ� ���� ���� ������
        int sceneCount = SceneManager.sceneCountInBuildSettings;

        // �ε����� ��ȿ���� Ȯ��
        if (sceneIndex >= 0 && sceneIndex < sceneCount)
        {
            // �� �ε�
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogWarning("Scene index is out of range.");
        }
    }
}