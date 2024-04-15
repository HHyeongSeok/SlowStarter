using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeDestroy : MonoBehaviour
{
    private bool playerOnBridge = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerOnBridge = true;
            Invoke("CollapseBridge", 2f); // 2초 후에 CollapseBridge 함수 호출
        }
    }

    private void CollapseBridge()
    {
        if (playerOnBridge)
        {
            Destroy(gameObject); // 오브젝트 제거
        }
    }
}
