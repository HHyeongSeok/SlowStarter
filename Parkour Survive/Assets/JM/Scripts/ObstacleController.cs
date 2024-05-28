using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI 네임스페이스 추가

public class ObstacleController : MonoBehaviour
{
    public int scoreValue = 10;
    public float hpIncreaseAmount = 10f;  // 충돌 시 증가할 HP 양

    // 자식 오브젝트에 부딪힐 때 실행되는 함수
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 객체가 플레이어인지 확인
        if (other.CompareTag("Player"))
        {
            // 점수 추가
            GameManager.Instance.AddScore(scoreValue);

            // 플레이어의 Player 스크립트를 가져옴
            Player player = other.GetComponent<Player>();

            // 플레이어가 존재하고, Player 스크립트가 존재하는 경우
            if (player != null)
            {
                // HP 슬라이더 값 증가
                player.IncreaseSliderValue(hpIncreaseAmount);
            }

            // 자식 오브젝트를 가지고 있는 부모 장애물을 파괴
            Destroy(transform.parent.gameObject);
        }
    }
}