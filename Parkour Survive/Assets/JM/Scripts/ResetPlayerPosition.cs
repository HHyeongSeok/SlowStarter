using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPosition : MonoBehaviour
{
    // 플레이어가 되돌려질 위치
    public Transform resetPosition;

    private void OnTriggerEnter(Collider other)
    {
        // 만약 다른 collider가 "Player" 레이어와 충돌했다면
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // 플레이어의 위치를 resetPosition으로 설정
            other.transform.position = resetPosition.position;
        }
    }
}