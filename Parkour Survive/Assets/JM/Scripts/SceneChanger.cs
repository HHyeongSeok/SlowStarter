using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // 씬 인덱스를 받아서 씬을 전환하는 메소드
    public void LoadSceneByIndex(int sceneIndex)
    {
        // 빌드 세팅에서 등록된 씬의 수를 가져옴
        int sceneCount = SceneManager.sceneCountInBuildSettings;

        // 인덱스가 유효한지 확인
        if (sceneIndex >= 0 && sceneIndex < sceneCount)
        {
            // 씬 로드
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogWarning("Scene index is out of range.");
        }
    }
}