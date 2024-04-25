using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    void Update()
    {
        // 'P' 키를 누르면 씬을 다시 시작
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            RestartScene();
        }
    }

    void RestartScene()
    {
        // 현재 씬을 다시 로드
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}