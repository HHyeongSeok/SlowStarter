using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject clearPanel; // 클리어 패널을 연결할 public 변수
    public LayerMask playerLayer; // 플레이어 레이어를 설정하기 위한 LayerMask

    private void OnTriggerEnter(Collider other)
    {
        // 플레이어 레이어인지 확인
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            clearPanel.SetActive(true); // 클리어 패널 활성화
        }
    }
}