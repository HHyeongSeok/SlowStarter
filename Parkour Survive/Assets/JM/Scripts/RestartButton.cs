using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    void Update()
    {
        // 'P' Ű�� ������ ���� �ٽ� ����
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        // ���� ���� �ٽ� �ε�
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}