using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // 자식 오브젝트에 부딪힐 때 실행되는 함수
    private void OnTriggerEnter(Collider other)
    {
        // 충돌한 객체가 플레이어인지 확인
        if (other.CompareTag("Player"))
        {
            // 자식 오브젝트를 가지고 있는 부모 장애물을 비활성화
            transform.parent.gameObject.SetActive(false);
        }
    }
}