using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI 네임스페이스 추가

public class ObstacleController : MonoBehaviour
{
    public int scoreValue = 10;

    // 자식 오브젝트에 부딪힐 때 실행되는 함수
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 객체가 플레이어인지 확인
        if (other.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
            GameManager.Instance.AddScore(scoreValue);
        }
    }
}