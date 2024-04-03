using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    // �浹 ���� �� ó��
    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� ���̾ Ȯ��
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // �浹�� ������Ʈ�� �θ� ������Ʈ�� �ı�
            Destroy(transform.parent.gameObject);
            Debug.Log("Obstacle and its parent destroyed.");
        }
    }
}