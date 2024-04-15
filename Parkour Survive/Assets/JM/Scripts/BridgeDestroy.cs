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
            Invoke("CollapseBridge", 2f); // 2�� �Ŀ� CollapseBridge �Լ� ȣ��
        }
    }

    private void CollapseBridge()
    {
        if (playerOnBridge)
        {
            Destroy(gameObject); // ������Ʈ ����
        }
    }
}
